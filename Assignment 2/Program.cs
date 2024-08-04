using System;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            findprime();
        }


        static void findprime()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Enter a positive integer ( or -1 to finish)");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == -1)
                {
                    System.Environment.Exit(0);
                }
                else if (num <= 0)
                {
                    Console.WriteLine("invalid number : please enter a positive integer");
                }
                else
                {
                    bool isPrime = true;

                    for (int j = 2; j <= num; j++)
                    {
                        if (num != j && num % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine(+num + "is a prime number");
                    }
                    else
                    {
                        Console.WriteLine(+num + "is not a prime number");

                    }


                }





            }
        }
    }
}
