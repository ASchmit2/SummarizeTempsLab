using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "";
            int threshold;
            string input;
            double average;
            int avgdenominator;
            bool choice = true;
            bool choice2 = true;

            Console.WriteLine("***Summarize Temperatures***");
            while (choice)
            {
                int above = 0;
                int below = 0;
                double sum = 0;

                while (choice2)
                {
                    Console.WriteLine("\nWhat file would you like to read?");
                    file = Console.ReadLine();
                    choice2 = false;
                }
 
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
                    Console.WriteLine("\nWould you like to continue summarizing temperatures? Type yes or no.");

                    if (Console.ReadLine() == "yes")
                    {
                        Console.WriteLine("\nWould you like to continue using the file " + file + "? Type yes or no.");
                        if (Console.ReadLine() == "yes")
                        {
                            choice = true;
                            choice2 = false;
                        }
                        else
                        {
                            choice = true;
                            choice2 = true;
                        }
                    }
                    else
                    {
                        choice = false;
                    }

                }
                else
                {
                    Console.WriteLine("\nThis File does not exist.");
                    Console.WriteLine("\nWould you like to choose another file? Type yes or no.");

                    if (Console.ReadLine() == "yes")
                    {
                        choice = true;
                        choice2 = true;
                    }
                    else
                    {
                        choice = false;
                    }
                }
            }
            Console.WriteLine("\nThis program has ended.");
        }
    }
}
