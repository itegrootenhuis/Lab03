using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Square and Cube displayer. \n");
            GetUserInput();
        }

        private static void GetUserInput()
        {
            Console.Write("Please enter an integer: ");
            int userInput = int.Parse(Console.ReadLine());

            CalculateInputPower(userInput, 2);
            CalculateInputPower(userInput, 3);
            CalculateInputPower(userInput, 10);
            CalculateInputPower(userInput, 100);
            QuitConsoleApp();
        }

        private static void CalculateInputPower(int userInput, int power)
        {
            double response;
            Console.WriteLine(string.Format("\nListing the numbers from 1 to {0} by the power of {1}: ", userInput, power));

            for (int i = 1; i <= userInput; i++)
            {
                response = Math.Pow(i, power);
                Console.WriteLine(string.Format("{0}^{1} = {2}", i, power, response));
            }
        }

        private static void QuitConsoleApp()
        {
            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                GetUserInput();
            }
        }
    }
}
