using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class BankATM
    {
        //Hub for login, transactions, displaying menus
        public void Execute()
        {                
            ATMMenu.DisplayMenu1();

            //Check for valid input, and execute command
            while(true)
            {
                switch(Utility.GetValidIntInput())
                {
                    case 1:
                        Console.WriteLine("Menu 2");
                        break;
                    case 2:
                        Console.WriteLine("Thank you for your money.");
                        break;
                    default:
                        Console.WriteLine("Invalid number entered.");
                        break;
                }
            }

        }
    }
}
