using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    class Program
    {
        //we can use @ instead of double slash (\\)
        const string path = @"C:\Users\vicun\source\repos\FileIODemo\FileIODemo\Example.txt";
        const string copy_path = "C:\\Users\\vicun\\source\repos\\FileIODemo\\FileIODemo\\ExampleNew.txt";
        static void Main(string[] args)
        {
            FileExists();
            //ReadAllLines();
            ReadAllText();
            Console.ReadKey();
        }
        public static void FileExists()
        {
            if (File.Exists(path))
                Console.WriteLine("File Exists");
            else
                Console.WriteLine("File Not Exists");
        }
        public static void ReadAllLines()
        {
            string[] lines;
            lines= File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        public static void FileCopy()
        {
            File.Copy(path, copy_path);
        }
        public static void DeleteFile()
        {
            File.Delete(path);
        }
        public static void ReadFromStreamReader()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while((s=sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                } 
            }
        }
        public static void WriteUsingStreamWrite()
        {
            using(StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello World- .NET is awesome.");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
