using System;
using System.IO;

namespace Filefuncations
{
    public class FileFunctionProgram
    {
        public static void Main(string[] args)
        {
            string writeText = "Hello, I am writing something on File";
            File.WriteAllText("filename.txt",writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine("Reading the data from File" + readText);
            
        }
    }
}
