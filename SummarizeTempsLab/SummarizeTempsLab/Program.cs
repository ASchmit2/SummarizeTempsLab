using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string file;
            int threshold;
            string input;

            Console.WriteLine("***Summarize Temperatures***\n");
            Console.WriteLine("What file would you like to read?");
            file = Console.ReadLine();

            if (File.Exists(file))
            {
                
                Console.WriteLine("\nWhat is you temperature threshold?");
                input = Console.ReadLine();
                threshold = int.Parse(input);

                
            }
            else
            {
                Console.WriteLine("\nThis File does not exist.");
            }
            
        }
    }
}
