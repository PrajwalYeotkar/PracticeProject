using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace practice1
{
    class firstproject
    {
        static void Main(string[] args){
            string filePath = @"C:\Users\prajwal.yeotkar\Desktop\PracticeProject\PracticeProject\studentdata1.txt";
            List<string> lines = new List<string>();
            lines  = File.ReadAllLines(filePath).ToList();
            Console.WriteLine("The Student's data is as follows: ");
            foreach(string line in lines){
                Console.WriteLine(line);
            }
        }
    }
}