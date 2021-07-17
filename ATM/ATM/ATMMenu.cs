using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public static class ATMMenu
    {
        //Display various menus
        public static void DisplayMenu1()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("| FakeBank ATM Main Menu |");
            Console.WriteLine("|                        |");
            Console.WriteLine("| 1. Insert ATM Card     |");
            Console.WriteLine("| 2. Exit                |");
            Console.WriteLine("|                        |");
            Console.WriteLine("--------------------------");
        }


        public static void DisplayMenu2()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------");
            Console.WriteLine("| Meybank ATM Secure Menu    |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. Balance Enquiry         |");
            Console.WriteLine("| 2. Cash Deposit            |");
            Console.WriteLine("| 3. Withdrawal              |");
            Console.WriteLine("| 4. Third Party Transfer    |");
            Console.WriteLine("| 5. Transactions            |");
            Console.WriteLine("| 6. Logout                  |");
            Console.WriteLine("|                            |");
            Console.WriteLine(" ---------------------------");
        }
    }    
}
