using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileParser
{
    class FileParser
    {
        private byte Option;
        private string PathToFile;
        private string LineToCount;
        public FileParser(byte option, string pathToFile, string lineToCount)
        {
            Option = option;
            PathToFile = pathToFile;
            LineToCount = lineToCount;
        }

        public void OptionController()
        {
            //Сделать проверку Option
            if (Option == 1)
            {
                StringOccur();
            }
            else if (Option == 2)
            {
                ReplaceString();
            }
        }
        public void StringOccur()
        {
            FileInfo fileInf = new FileInfo(PathToFile);
            if (fileInf.Exists)
            {
                using (FileStream fstream = File.OpenRead($"{PathToFile}"))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                    string textFromFile = /*System.Text.*/Encoding.Default.GetString(array);
                    Console.WriteLine($"Text from file: {textFromFile}");
                    int i = 0;
                    string[] textMas = textFromFile.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string s in textMas)
                    {
                        if (s.Equals(LineToCount) == true)
                        {
                            i++;
                        }
                    }

                    Console.WriteLine("Count:" + i);
                }
            }
        }
        public void ReplaceString()
        {
            Console.WriteLine("Enter the replacement string:");
            string lineToChange = Console.ReadLine();
            int i = 0;
            FileInfo fileInf = new FileInfo(PathToFile);
            if (fileInf.Exists)
            {
                using (FileStream fstream = File.OpenRead($"{PathToFile}"))
                {
                    byte[] array = new byte[fstream.Length];//Вспомнить как это работает
                    fstream.Read(array, 0, array.Length);
                    string textFromFile = /*System.Text.*/Encoding.Default.GetString(array);
                    Console.WriteLine($"Text from file: {textFromFile}");
                    string[] textMas = textFromFile.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    fstream.Close();
                    // using (FileStream wstream = File.OpenWrite($"{path}"))
                    //{
                    foreach (string s in textMas)
                    {

                        if (s.Equals(LineToCount) == true)
                        {
                            textMas[i] = textMas[i].Replace(LineToCount, lineToChange);
                            //array = System.Text.Encoding.Default.GetBytes(textMas[i]);

                        }

                        //Console.WriteLine(textMas[i]);
                        i++;
                    }
                    string joined = string.Join(" ", textMas);
                    File.WriteAllText(PathToFile, joined);

                    //}
                    //textFromFile = String.Join(" ",textMas);
                    Console.WriteLine($"Final Result: { joined}");
                    //File.WriteAllLines(path, textMas);

                }
            }
        }
    }
}
