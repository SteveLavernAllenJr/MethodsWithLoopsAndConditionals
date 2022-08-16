using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            PrintByThree();
            Console.WriteLine(TwoIntegers(2, 8));
            EvenOrOdd();
            CanVote();
            IntRange();
            TimesTable();
        }
        // Write a method that will print to the console all numbers 1000 through -1000.
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void PrintByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // Write a method to accept two integers as parameters and check whether they are equal or not.
        public static bool TwoIntegers(int a, int b)
        {
            var check = (a == b) ? true : false;
            return check;
        }
        // Write a method to check whether a given number is even or odd.

        public static void EvenOrOdd()
        {
            Console.WriteLine("Give me a number...");
            int num = Convert.ToInt32(Console.ReadLine());

            var evenOrOdd = (num % 2 == 0) ? "That number is even!" : "That number is odd!";

            Console.WriteLine(evenOrOdd);
        }
        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void CanVote()
        {
            Console.WriteLine("Let's find out if you're old enough to vote!" +
                " How old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            var voterResponse = (userAge >= 18) ? "Great! Go do your civic duty!" : "Sorry, it won't be too much longer!";

            Console.WriteLine(voterResponse);
        }
        //Write a method to check if an integer (from the user) is in the range -10 to 10.
        public static void IntRange()
        {
            Console.WriteLine("Give me a number betwen -10 and 10!");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            var numberRange = (userNumber >= -10 && userNumber <= 10) ? "Thank you for following instructions!" : "Can you not read???";
            Console.WriteLine(numberRange);
        }
        //Write a method to display the multiplication table (from 1 to 12) of a given integer
        public static void TimesTable()
        {
            Console.WriteLine("Let's practice our multiplication tables. Give me a number!");
            int num = Convert.ToInt32(Console.ReadLine());

            var timesTableList = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            foreach (var number in timesTableList)
            {
                var answer = (num * number);
                Console.WriteLine($"{answer}");
            }

        }
    }
}

    



