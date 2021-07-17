using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ATM
{

    public enum SecureMenu
    {
        CheckBalance = 1,
        MakeDeposit = 2,
        MakeWithdrawl = 3,
        ThirdPartyTransfer = 4,
        ViewTransactions = 5,
        Logout = 6
    }
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
