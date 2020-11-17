using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.IsolatedStorage;
using System.IO;

namespace store
{
    class Program
    {
        static void Main(string[] args)
        {
            //Хранилище уровня компьютера (Assembly/ Machine)
            IsolatedStorageFile machineStorage = IsolatedStorageFile.GetMachineStoreForAssembly();
            //Хранилище уровня пользователя (Assembly/User)
            IsolatedStorageFile userStore = IsolatedStorageFile.GetUserStoreForAssembly();


            //Класс IsolatedStorageFileStream
            
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStore);

            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("User Prefs");
            userWriter.Close(); 

            //чтение
            string[] files = userStore.GetFileNames("UserSettings.set");
            if (files.Length == 0)
            {
                Console.WriteLine("No data saved for this user");

            }
            else
            {
                userStream = new IsolatedStorageFileStream("UserSettings.set",FileMode.Open, userStore);
                StreamReader userReader = new StreamReader(userStream);
                string contents = userReader.ReadToEnd();
                Console.WriteLine(contents);

            }


        }
    }
}
