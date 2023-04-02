using System;

namespace S1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("What is your name?");

            name = Console.ReadLine() + ".";

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome " + name);
                Console.WriteLine();
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Multiply two numbers");
                Console.WriteLine("3. Subtract two numbers");
                Console.WriteLine("4. Divide two numbers");


                bool optionIsValid = false;
                int option = 1;

                while(optionIsValid == false)
                {
                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                        optionIsValid = true;
                    }
                    catch { }
                }
                


                int firstNum;
                int secondNum;

                if (option == 1)
                {
                    Console.Write("First Number: ");
                    firstNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Second Number: ");
                    secondNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Result: " + (firstNum + secondNum));
                }
                else if (option == 2)
                {
                    Console.Write("First Number: ");
                    firstNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Second Number: ");
                    secondNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Result: " + (firstNum * secondNum));
                }
                else if (option == 3)
                {
                    Console.Write("First Number: ");
                    firstNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Second Number: ");
                    secondNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Result: " + (firstNum - secondNum));
                }
                else
                {
                    Console.Write("First Number: ");
                    firstNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Second Number: ");
                    secondNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Result: " + (firstNum / secondNum));
                }
                Console.ReadLine();
            }
        }
    }
}
