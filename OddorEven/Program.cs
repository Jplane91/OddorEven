using System;

namespace OddorEven
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter a number between 1 and 100");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber > 0 && userNumber < 101)
            {
                if (userNumber % 2 == 0 && userNumber > 1 && userNumber <= 25)
                {
                    Console.WriteLine(userName + " the number is even and between 2 and 25");
                }

                else if (userNumber % 2 == 0 && userNumber > 25 && userNumber < 60)
                {
                    Console.WriteLine(userName + " the number is even and between 26 and 60");
                }

                else if (userNumber % 2 == 0 && userNumber > 60)
                {
                    Console.WriteLine(userName + " the number is even and greater than 0");
                }

                else if (userNumber % 2 == 1 && userNumber > 60)
                {
                    Console.WriteLine(userName + " the number is odd and greater than 60");
                }

                else
                {
                    Console.WriteLine(userName + " the number is odd");
                }


            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadKey();
        }
    }
}