using System;

namespace RandomProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculator

            /*
            Console.Title = "Calculator by Alex";

            double firstNumber;
            double secondNumber;

            Console.Write("Please type the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            double result;
            result = firstNumber + secondNumber;

            Console.WriteLine("Result: " + result);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            */

            // Average Calculator

            /*
            Console.Title = "Average calculator by Alex";

            double firstNumber;
            double secondNumber;
            double thirdNumber;

            Console.Write("Please type the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please type the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please type the third number: ");
            thirdNumber = Convert.ToDouble(Console.ReadLine());

            double result1;
            result1 = firstNumber + secondNumber + thirdNumber;

            double result2;
            result2 = result1 / 3;

            Console.WriteLine("Average: " + result2);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            */

            // Mini Quiz

            /*
            string answer;

            Console.WriteLine("Welcome to the quiz!\nReply to the answers with yes or no\n");

            Console.WriteLine("Is this program programmed in C#?");
            answer = Console.ReadLine();

            if(answer == "yes") {
                Console.WriteLine("Correct!");
            }
            else {
                Console.WriteLine("Incorrect!");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            */

            // Counter from 1 to 10

            /*
            for(int i = 1;i <= 10;i++) {
                Console.WriteLine(i);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            */

            // Guess the number

            /*
            int guess;
            int correctNumber;
            int attempts = 0;

            Random numberGen = new Random();

            correctNumber = numberGen.Next(1, 10);

            Console.WriteLine("Try to guess my number between 1 and 10:");

            while(attempts <= 4) {
              attempts++;

              guess = Convert.ToInt32(Console.ReadLine());

              if(guess != correctNumber) {
                Console.WriteLine("Incorrect!");
              } else {
                Console.WriteLine("Correct!");
                break;
              }
            }

            if(attempts <= 4) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey();
            } else {
                Console.WriteLine("You didn't guess the number after 5 attempts");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey();
            }
            */

            // Random numbers from 0 to 100 with function

            /*
            int randomNumberAmount;
            int randomNumberCount = 1;

            Console.WriteLine("How many random numbers do you want?");
            randomNumberAmount = Convert.ToInt32(Console.ReadLine());

            while(randomNumberCount <= randomNumberAmount) {
                RandomNumber();
                randomNumberCount++;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            */
        }

        static void RandomNumber() {
            Random numberGen = new Random();
            int number = numberGen.Next(1, 100);
            Console.WriteLine(number);
        }
    }
}