using System;
using System.IO;

namespace fileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\joao.alves\source\repos\FileUsing\archivements\lorem.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            } catch(IOException e)
            {
                Console.WriteLine("Um erro Ocorreu");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
