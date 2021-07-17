using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            BankATM fakeBank = new BankATM();

            fakeBank.Initialization();
            fakeBank.Execute();
        }
    }
}
