using System;
using System.IO;

namespace usingBock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\joao.alves\source\repos\FileUsing\FileStream\lorem.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro foi encontrado");
                Console.WriteLine(e.Message);
            }
        }
    }
}
