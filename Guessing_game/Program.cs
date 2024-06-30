using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ans = "";
            bool flag = false;
            Random random = new Random();
            int ans1 = random.Next(1, 5);
            Console.WriteLine("Welcome,Do you want to play a guessing game?");
            Console.WriteLine("If your answer is yes enter 'Y' else enter 'N'");
            ans = Console.ReadLine();
            if (ans == "Y")
            {
                int res;

                while (!flag)
                {
                    Console.WriteLine("Enter a number from 1 upto 5.");
                    res = Convert.ToInt32(Console.ReadLine());
                    if (res > ans1)
                    {
                        Console.WriteLine("Please Try again!");
                    }
                    else if (res < ans1)
                    {
                        Console.WriteLine("Please Try again!");
                    }
                    else
                    {
                        Console.WriteLine("Correct" +
                            "!");
                        flag = true;
                    }



                }
                Console.WriteLine("Congratualation you won!");
                Console.WriteLine("Good Bye!");

            }
            else
            {
                Console.WriteLine("Try Again!");
     
                
            }
            Console.ReadLine();
        }
    }
}
