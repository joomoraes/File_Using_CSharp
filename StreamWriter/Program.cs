using System;
using System.IO;

namespace streamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\joao.alves\source\repos\FileUsing\archivements\lorem.txt";
            string targetPath = @"C:\Users\joao.alves\source\repos\FileUsing\archivements\lorem2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            } catch(IOException e)
            {
                Console.WriteLine("Um Erro Foi Encoontrado!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
