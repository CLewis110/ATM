using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public static class Utility
    {
        //Ask for input, Check for valid inputs, print messages, formatting
        public static Int64 GetValidIntInput()
        {
            string rawInput;
            bool valid = false;
            Int64 userSelection = 0;

            while(!valid)
            {
                rawInput = GetRawInput();
                valid = Int64.TryParse(rawInput, out userSelection);
                if(!valid)
                {
                    Console.WriteLine("Invalid number.");
                }
            }
            return userSelection;
        }

        public static string GetRawInput()
        {
            Console.Write("Enter your option: ");
            return Console.ReadLine();
        }
    }
}
