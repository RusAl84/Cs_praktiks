// БББО - 01 - 20 Георгий Евдоким Blu_berry ge02mail@mail.ru

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace MusicProj
{
  class Program
  {



    static void Main(string[] args)
    {
      var song1 = "440 250 440 250 523 250 440 250 587 250 440 250 659 250 587 250 523 250 523 250 659 250 523 250 784 250 523 250 659 250 523 250 392 250 392 250 493 250 392 250 523 250 392 250 587 250 523 250 349 250 349 250 440 250 349 250 523 250 349 250 523 250 493 250 0 50 440 250 440 250 523 250 440 250 587 250 440 250 659 250 587 250 523 250 523 250 659 250 523 250 784 250 523 250 659 250 523 250 392 250 392 250 493 250 392 250 523 250 392 250 587 250 523 250 349 250 349 250 440 250 349 250 523 250 349 250 523 250 493 250 0 50";
      var song2 = "440 375 440 375 440 375 440 375 392 250 523 250 440 375 440 375 440 375 440 375 392 250 329 250 440 375 440 375 440 375 440 375 392 250 523 250 440 375 440 375 440 250 440 125 440 250 440 125 440 375 0 250";
      var song3 = "440 125 659 250 440 125 523 250 440 125 466 250 440 125 523 250 440 125 466 125 392 250 440 125 659 250 440 125 523 250 440 125 466 250 440 125 523 250 440 125 466 125 392 250 440 125 659 250 440 125 523 250 440 125 466 250 440 125 523 250 440 125 466 125 392 250";
      var song4 = "440 125 659 250 440 125 523 250 392 125 392 259 440 125 440 250 440 500 0 125";
      var song5 = "440 500 0 100 440 500 0 100 440 500 0 100 440 500 0 125";
      var song1d = "440 250 440 250 523 250 440 250 587 250 440 250 659 250 587 250 523 250 523 250 659 250 523 250 784 250 523 250 659 250 523 250 392 250 392 250 493 250 392 250 523 250 392 250 587 250 523 250 349 250 349 250 440 250 349 250 523 250 349 250 523 250 493 250";
      Play(song1);
      for (int j = 0; j < 2; j++)
      {
        Play(song2);
      }
      Play(song3);
      Play(song4);
      Play(song3);
      Play(song5);
      Play(song1d);
      for (int j = 0; j < 2; j++)
      {
        Play(song2);
      }
    }


    static void Play(string sounds)
    {
      var nums = sounds.Split(" \t\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
      for (int i = 0; i < nums.Length; i += 2)
      {
        if (nums[i] == 0)
        {
          Thread.Sleep(nums[i + 1]);
        }
        else
        {
          Console.Beep(nums[i], nums[i + 1]);
        }
      }
    }
    static int NoteNum(int n)
    {
      double f; int g;
      f = 27.5 * Math.Pow(2, (n / 12));
      g = (int)f;
      return g;
    }
    static int NoteSearch(String note, int numOct)
    {
      int gerc = 0; int[] massiveGerc = new int[123]; string[] massiveNote = new string[12];
      massiveNote[0] = "C"; massiveNote[1] = "Db"; massiveNote[2] = "D"; massiveNote[3] = "Eb"; massiveNote[4] = "E";
      massiveNote[5] = "F"; massiveNote[6] = "Gb"; massiveNote[7] = "G"; massiveNote[8] = "Ab"; massiveNote[9] = "A";
      massiveNote[10] = "B"; massiveNote[11] = "H";
      for (int i = 0; i < 123; i++)
      {
        massiveGerc[i] = NoteNum(i);
      }
      if (numOct != 0)
      {
        for (int i = 12 * (numOct - 1) + 3; i < 123; i++)
        {
          if (note == massiveNote[(i - 3) % 12])
          {
            gerc = massiveGerc[i];
          }
        }
      }
      else
      {
        for (int i = 0; i < 3; i++)
        {
          if (note == massiveNote[i + 9])
          {
            gerc = massiveGerc[i];
          }
        }
      }
      return gerc;
    }
  }
}