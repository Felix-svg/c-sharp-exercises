using System;

namespace Practice
{
    class Program
    {
        // take a users name, age, height and output results
        static void Person(string name, int age, double height)
        {
            Console.WriteLine($"{name} of age {age} is {height} cm tall.");
        }

        // convert degree celcius to fahrenheit
        static void DegreeToFahrenheit(double temp)
        {
            double fahrenheit = (temp * 1.8) + 32;
            Console.WriteLine($"{temp} degrees celcius is equivalent to {fahrenheit} Fahrenheit.");
        }

        // a program that takes a number as input and prints whether it’s even or odd.
        static void EvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        //a program that asks the user to enter a day number (1-7) and outputs the corresponding day of the week (e.g., 1 = Monday).
        static void DayNumber()
        {
            Console.Write("Please enter a day of the week (1-7): ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("What day?");
                    break;
            }
        }

        // a program that prints the first 10 numbers in the Fibonacci sequence.
        static void Fibonacci(int N)
        {
            int prev1 = 0;
            int prev2 = 1;
            for (int i = 0; i < N; i++)
            {
                int newFibo = prev1 + prev2;
                Console.WriteLine(newFibo);
                prev1 = prev2;
                prev2 = newFibo;
            }
        }

        // a program that prints all numbers from 1 to 100, but for multiples of 3 print “Fizz” instead of the number and for multiples of 5 print “Buzz”. For numbers which are multiples of both 3 and 5, print “FizzBuzz”.
        static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} - Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} - Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        // a program that calculates the sum of all even numbers between 1 and 50 using a for loop
        static void SumOfEvenNums()
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        // a program that takes an integer input and prints its multiplication table (up to 10).
        static void NumberMultiplication(int N)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(N * i);
            }
        }

        //  a method that takes an integer array as input and returns the maximum value in the array
        static void Maximum(int[] nums)
        {
            Console.WriteLine(nums.Max());
        }

        // a program to generate a half pyramid pattern using numbers.
        static void Pyramid(int R)
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = R-i; j <= R; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }


        //  a method that checks whether a given string is a palindrome
        // static void Palindrome(string S)
        // {
        //     int start = 0;
        //     int end = S.Length - 1;
        //     for(int i = 0; i<S.Length; i++)
        //     {

        //     }

        // }

        static void Main(string[] args)
        {
            // Person("Jon Doe", 45, 187.3);
            // DegreeToFahrenheit(30);
            // EvenOdd(30);
            // DayNumber();
            // Fibonacci(18);
            //FizzBuzz();
            // SumOfEvenNums();
            // NumberMultiplication(3);
            //Maximum([4, 7, 2, 39, 15, 5, 10]);
            Pyramid(5);
        }
    }
}