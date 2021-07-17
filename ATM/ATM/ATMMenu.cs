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
    }
}
