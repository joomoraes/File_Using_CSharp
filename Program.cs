using System;
using System.IO;


namespace FileUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\joao.alves\source\repos\FileUsing\archivements\lorem.txt";
            string targetPath = @"C:\Users\joao.alves\source\repos\FileUsing\archivements\lorem2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            } catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
