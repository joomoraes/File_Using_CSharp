using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\joao.alves\source\repos\FileUsing\archivements";

            try
            {
                // PEGAR CAMINHOS
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folder)
                {
                    Console.WriteLine(s);
                }

                //LISTA OS ARQUIVOS NAS PASTAS

                IEnumerable<string> files = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //CRIAR PASTA 

                Directory.CreateDirectory(path + "\\newfolder");


            } catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
