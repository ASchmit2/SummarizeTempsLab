using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double delay = 2000;
            string file;
            int threshold;
            string input;
            double average;
            int avgdenominator;
            bool choice = true;

            Console.WriteLine("***Summarize Temperatures***");
            while (choice)
            {
                int above = 0;
                int below = 0;
                double sum = 0;

                Console.WriteLine("\nWhat file would you like to read?");
                file = Console.ReadLine();

                if (File.Exists(file))
                {
                    Console.WriteLine("\nWhat is your temperature threshold?");
                    input = Console.ReadLine();
                    threshold = int.Parse(input);
                    using (StreamReader sr = File.OpenText(file))
                    {
                        string line = "";
                        int temp;

                        while ((line = sr.ReadLine()) != null)
                        {
                            temp = int.Parse(line);
                            if (temp >= threshold)
                            {
                                above++;
                                sum = sum + temp;
                            }
                            else
                            {
                                below++;
                                sum = sum + temp;
                            }
                        }

                    }
                    avgdenominator = below + above;
                    average = sum / avgdenominator;
                    Console.WriteLine("\nThere are " + above + " temperatures above " + threshold + ".");
                    Console.WriteLine("\nThere are " + below + " temperatures below " + threshold + ".");
                    Console.WriteLine("\nThe average temperature is " + average + ".");
                    TimeSpan.FromSeconds(delay);
                    Console.WriteLine("\nWould you like to choose another file? Type yes or no.");

                    if (Console.ReadLine() == "yes")
                    {
                        choice = true;
                    }
                    else
                    {
                        choice = false;
                    }
                }
                else
                {
                    Console.WriteLine("\nThis File does not exist.");
                    Console.WriteLine("\nWould you like to choose a different file? Type yes or no.");

                    if (Console.ReadLine() == "yes")
                    {
                        choice = true;
                    }
                    else
                    {
                        choice = false;
                    }
                }
            }
            Console.WriteLine("This program has ended.");
        }
    }
}
