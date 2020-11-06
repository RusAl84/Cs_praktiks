using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;


namespace demo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      SoundPlayer player = new SoundPlayer();
      player.SoundLocation = "1.wav";
      player.Load();
      player.Play();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      //Declare your new form
      Form2 form2 = new Form2();
      form2.Show();
      SoundPlayer player = new SoundPlayer();
      player.SoundLocation = "2.wav";
      player.Load();
      player.Play();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      MessageBox.Show("ХОЧУ ПИВА");
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      SoundPlayer player = new SoundPlayer();
      player.SoundLocation = "1.wav";
      player.Load();
      player.Play();
      //Declare your new form
      Form2 form2 = new Form2();
      form2.Show();
    }

    private void button1_MouseMove(object sender, MouseEventArgs e)
    {
      SoundPlayer player = new SoundPlayer();
      player.SoundLocation = "1.wav";
      player.Load();
      player.Play();
    }

    private void button4_Click(object sender, EventArgs e)
    {

      IWavePlayer waveOutDevice = new WaveOut();
      AudioFileReader audioFileReader = new AudioFileReader("1.mp3");

      waveOutDevice.Init(audioFileReader);
      waveOutDevice.Play();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      IWavePlayer waveOutDevice = new WaveOut();
      AudioFileReader audioFileReader = new AudioFileReader("2.mp3");

      waveOutDevice.Init(audioFileReader);
      waveOutDevice.Play();
    }
  }
}
