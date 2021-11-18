using System;
using System.IO;
namespace createLogitpe21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string directoryName = "LOGITpe21";
            CreateMyDirectory(directoryName);
        }

        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string directoryPath = $@"{rootDirectory}\{myDirectoryName}.";
            if (Directory.Exists(directoryPath))
            {
                Console.WriteLine($"Directory {myDirectoryName} already exists in {directoryPath}");
            }
            else
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Directory {myDirectoryName} has been created");
            }


        }
    }
}
