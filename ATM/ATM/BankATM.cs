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
            while(true)
            {
                ATMMenu.DisplayMenu1();
                break;
            }
        }
    }
}
