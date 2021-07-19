using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class BankATM
    {
        //Hub for login, transactions, displaying menus
        private static List<BankAccount> _accountList;
        private static BankAccount selectedAccount;
        private const int maxTries = 3;
        private static int tries = 0;

        private static decimal transaction_amount;

        public void Execute()
        {                
            ATMMenu.DisplayMenu1();

            //Check for valid input, and execute command
            while(true)
            {
                switch(Utility.GetValidIntInput("your option"))
                {
                    case 1:
                        CheckCardNumAndPin();

                        while(true)
                        {
                            ATMMenu.DisplayMenu2();

                            switch(Utility.GetValidIntInput("your option"))
                            {
                                case (int)SecureMenu.CheckBalance:
                                    CheckBalance(selectedAccount);
                                    break;
                                case (int)SecureMenu.MakeDeposit:
                                    MakeDeposit(selectedAccount);
                                    break;
                                case (int)SecureMenu.MakeWithdrawl:
                                    MakeWithdrawal(selectedAccount);
                                    break;
                                case (int)SecureMenu.ThirdPartyTransfer:
                                    break;
                                case (int)SecureMenu.ViewTransactions:
                                    break;
                                case (int)SecureMenu.Logout:
                                    Utility.PrintMessage("Sucessfully logged out.");
                                    Execute();
                                    break;
                                default:
                                    break;
                            }
                        }
                    case 2:
                        Console.WriteLine("Thank you banking with FakeBank.");
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid number entered.");
                        break;
                }
            }

        }

        public void MakeWithdrawal(BankAccount selectedAccount)
        {
            //Ask how much money user would like to withdrawl
            transaction_amount = Utility.GetValidDecimalInput("amount to withdrawal");
            //Check if desired withdrawl is a valid amount
            if(transaction_amount <= 0)
            {
                Utility.PrintMessage("Not a valid amount.  Please try again");
            }
            else
            {
                //Check if money is available in account
                if(transaction_amount > selectedAccount.Balance)
                {
                    Utility.PrintMessage("Insufficient funds.");
                }
                else
                {
                    //TODO: Create transaction record

                    //Subtract money from account
                    selectedAccount.Balance -= transaction_amount;

                    //Dispense money
                    //Message saying here's your money
                    Utility.PrintMessage($"Please collect your money.  You have successfully withdrawn {Utility.FormatAmount(transaction_amount)}");
                }

            }
        }

        public void MakeDeposit(BankAccount account)
        {
            transaction_amount = Utility.GetValidDecimalInput("amount to deposit");

            //TODO: Check if amountToDeposit is a valid number
            if(transaction_amount <= 0)
            {
                Utility.PrintMessage("Amount must be more than zero.  Please try again.");
            }
            else 
            {
                //TODO: Create transaction record

                account.Balance += transaction_amount;
                Utility.PrintMessage($"{Utility.FormatAmount(transaction_amount)} has been deposited into your account.");
            }
        }

        //Check card number and pin
        public void CheckCardNumAndPin()
        {           
            bool pass = false;

            while (!pass)
            {
                BankAccount inputAccount = new BankAccount();

                //Ask for card number
                inputAccount.CardNumber = Utility.GetValidIntInput("your card number");
                
                //Ask for pin number    
                inputAccount.PinNumber = Utility.GetValidIntInput("your pin number");

                foreach (BankAccount account in _accountList)
                {
                    //Check for matching card number against database
                    if (inputAccount.CardNumber.Equals(account.CardNumber))
                    {
                        selectedAccount = account;

                        //Check check if pin matches card number pin
                        if (inputAccount.PinNumber.Equals(selectedAccount.PinNumber))
                        {
                            if (selectedAccount.isLocked)
                            {
                                NotifyAccountLocked();
                            }
                            else
                            {
                                pass = true;
                            }
                        }
                        else
                        {
                            pass = false;
                            tries++;

                            if (tries >= maxTries)
                            {
                                selectedAccount.isLocked = true;
                                NotifyAccountLocked();
                            }
                        }
                    }
                }

                if (!pass)
                {
                    Utility.PrintMessage("\n\nInvalid card number or PIN.");
                    Console.Clear();
                }
            }
        }

        //Create accounts
        public void Initialization()
        {
            _accountList = new List<BankAccount>
            {
                new BankAccount() {UserName = "Charlie Charleston", AccountNumber = 1234567890, CardNumber = 123, PinNumber = 1111, Balance = 1000000},
                new BankAccount() {UserName = "Kaityln Kaiterson", AccountNumber = 0987654321, CardNumber = 321, PinNumber = 2222, Balance = 26}
            };
        }
        public void CheckBalance(BankAccount bankAccount)
        {
            Utility.PrintMessage($"Your bank account balance is: {Utility.FormatAmount(bankAccount.Balance)}");
        }

        public void NotifyAccountLocked()
        {
            Utility.PrintMessage("Your account has been locked.  Police are on the way.  Please stay where you are.");
            System.Environment.Exit(1);
        }
    }
}
