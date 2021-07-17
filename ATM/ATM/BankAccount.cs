using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class BankAccount
    {
        //Contain individual account info
        public string UserName { get; set; }
        public Int64 AccountNumber { get; set; }
        public Int64 CardNumber { get; set; }
        public Int64 PinNumber { get; set; }
        public decimal Balance { get; set; }
        public int triesLeft { get; set; }
        public bool isLocked { get; set; }
    }
}
