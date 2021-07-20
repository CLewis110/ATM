using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class Transaction
    {
        public int TransactionId { get; set; }
        public decimal TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }

        public Int64 BankAccountNoFrom { get; set; }
        public Int64 BankAccountNoTo { get; set; }
        public TransactionType TypeOfTransaction { get; set; }

        public enum TransactionType
        {
            Deposit,
            Withdrawal,
            ThirdPartyTransfer
        }
    }
}
