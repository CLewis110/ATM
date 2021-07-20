using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    interface IBalance
    {
        public void CheckBalance(BankAccount bankAccount);
    }
}
