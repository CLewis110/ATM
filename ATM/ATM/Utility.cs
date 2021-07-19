using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public static class Utility
    {

        //Ask for input, Check for valid inputs, print messages, formatting
        public static Int64 GetValidIntInput(string input)
        {
            string rawInput;
            bool valid = false;
            Int64 userSelection = 0;

            while(!valid)
            {
                rawInput = GetRawInput(input);
                valid = Int64.TryParse(rawInput, out userSelection);
                if(!valid)
                {
                    Console.WriteLine("Invalid number.");
                }
            }
            return userSelection;
        }

        public static decimal GetValidDecimalInput(string input)
        {
            string rawInput;
            bool valid = false;
            decimal userSelection = 0;

            while (!valid)
            {
                rawInput = GetRawInput(input);
                valid = decimal.TryParse(rawInput, out userSelection);
                if (!valid)
                {
                    Console.WriteLine("Invalid number.");
                }
            }
            return userSelection;
        }

        public static string GetRawInput(string message)
        {
            Console.Write($"Enter {message}: ");
            return Console.ReadLine();
        }

        public static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        public static string FormatAmount(decimal amt)
        {
            return "$" + String.Format("{0:0.00}", amt);
        }
    }
}
