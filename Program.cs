using System;

namespace Lab3NumberAnalyzer_Decision_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //extra challenge 2
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();        
            bool rangeCheck = true;
            bool runAgain = true;
            
            while(runAgain)
            {
                // checks if within range
                while (rangeCheck)
                {
                    Console.Write($"Great! {name}, please enter a number between 1 and 100: ");
                    int num = int.Parse(Console.ReadLine());

                    if (num <= 0 || num >= 101)
                    {
                        Console.WriteLine("I am sorry. That number is not between 1 and 100. Please enter a different number.");
                        rangeCheck = true;
                    }
                    //I am sure there is a cleaner way to do this and looking forward to seeing an example by Justin                    
                    else if (num % 2 == 0 && num > 0 && num < 25)
                    {
                        Console.WriteLine("Even and less than 25.");
                        break;
                    }
                    else if (num % 2 == 0 && num > 25 && num < 61)
                    {
                        Console.WriteLine("Even.");
                        break;
                    }
                    else if (num % 2 == 0 && num > 60 && num <= 100)
                    {
                        Console.WriteLine("Even.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{num} and odd.");
                        break;
                    }
                } 

                Console.WriteLine($"{name}, would you like to run a different number? Enter 'y' to continue or any other key to exit.");
                string runInput = Console.ReadLine().ToLower();
                    if (runInput == "y")
                    {
                        runAgain = true;
                    }
                    else
                    {
                        runAgain = false;
                    //extra challenge 1
                        Console.WriteLine($"Bye, {name}!");
                    }

            }

        }
    }
}
