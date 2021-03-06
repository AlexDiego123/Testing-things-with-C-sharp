using System;

namespace RandomProject
{

    class Calculator {

        public int GuessTheNumber(int difficulty) {
            Random numberGen = new Random();
            int number = 0;

            switch(difficulty) {
                case 1:
                    number = numberGen.Next(1, 20);
                    break;
                case 2:
                    number = numberGen.Next(1, 50);
                    break;
                case 3:
                    number = numberGen.Next(1, 100);
                    break;
            }

            return number;
        }
        public int GenerateNum(int num01, int num02) {
            Random numberGen = new Random();

            int result = numberGen.Next(num01, num02);

            return result;
        }

        public int Add(int num01, int num02) {
            int result = num01 + num02;

            return result;
        }

        public int Subtract(int num01, int num02) {
            int result = num01 - num02;

            return result;
        }

        public int Multiply(int num01, int num02) {
            int result = num01 * num02;

            return result;
        }

        public int Divide(int num01, int num02) {
            int result = num01 / num02;

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

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

            // Calculator with class

            /*
            string operator2;
            int firstnum;
            int secondnum;
            int result;

            Console.Write("Please enter an operator (+,-,/,*): ");
            operator2 = Console.ReadLine();

            Console.Write("Please enter the first number: ");
            firstnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            secondnum = Convert.ToInt32(Console.ReadLine());

            switch(operator2) {
                case "+":
                    result = calc.Add(firstnum, secondnum);

                    Console.WriteLine("Result: " + result);
                    break;
                case "-":
                    result = calc.Subtract(firstnum, secondnum);

                    Console.WriteLine("Result: " + result);
                    break;
                case "*":
                    result = calc.Multiply(firstnum, secondnum);

                    Console.WriteLine("Result: " + result);
                    break;
                case "/":
                    result = calc.Divide(firstnum, secondnum);

                    Console.WriteLine("Result: " + result);
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            */

            // Number generator with class

            /*
            int amount;
            int generatedNumbersCount = 0;
            int num1;
            int num2;
            int result;

            Console.Write("How many random numbers do you want: ");
            amount = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("The random numbers have to be between: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("And: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            while(generatedNumbersCount <= amount) {
                result = calc.GenerateNum(num1, num2);

                Console.WriteLine(result);
                generatedNumbersCount++;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            */

            // Guess the number v3

            /*
            int difficulty;
            int result;

            Console.Write("Difficulty (1,2,3): ");
            difficulty = Convert.ToInt32(Console.ReadLine());

            if(difficulty != 1 && difficulty != 2 && difficulty != 3) {
                Console.WriteLine("Invalid Difficulty");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey();
            } else {
                result = calc.GuessTheNumber(difficulty);

                switch(difficulty) {
                    case 1:
                        Console.WriteLine("Try to guess my number from 0 to 20, you have 5 attempts");
                        GuessTheNumberStart(result);
                        break;
                    case 2:
                        Console.WriteLine("Try to guess my number from 0 to 50, you have 5 attempts");
                        GuessTheNumberStart(result);
                        break;
                    case 3:
                        Console.WriteLine("Try to guess my number from 0 to 100, you have 5 attempts");
                        GuessTheNumberStart(result);
                        break;
                }
            }
            */
        }

        static void RandomNumber() {
            Random numberGen = new Random();
            int number = numberGen.Next(1, 100);
            Console.WriteLine(number);
        }

        static void GuessTheNumberStart(int result) {
            int guess;
            int attemptsCount = 0;
            
            while(attemptsCount <= 4) {
                guess = Convert.ToInt32(Console.ReadLine());

                if(guess == result) {
                    Console.WriteLine("Correct!");
                    break;
                } else {
                    Console.WriteLine("Incorrect");
                    attemptsCount++;
                    continue;
                }
            }

            if(attemptsCount >= 4) {
                Console.WriteLine("You didn't guess the number after 5 attempts");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey();
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey();
            }
        }
    }
}