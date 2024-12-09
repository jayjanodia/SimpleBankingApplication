using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    public class Account
    {

        public event EventHandler<string> TransactionApprovedEvent;
        public event EventHandler<decimal> OverdraftEvent;

        public int AccountNumber { get; set; }
        public decimal Balance { get; private set; } // dealing with money, decimal is precise
        private List<string> _transactions = new List<string>();

        // User will have access to the list of transactions but won't be able to modify the contents directly
        public IReadOnlyList<string> Transactions
        {
            get { return _transactions.AsReadOnly(); }
        }

        /// <summary>
        /// Put money into the account
        /// </summary>
        /// <param name="depositName"></param>
        /// <param name="Amount"></param>
        /// <returns></returns>
        public bool AddDeposit(string depositName, decimal amount)
        {
            // Amount is being passed in as dollars rounded to 2 decimal places.
            _transactions.Add($"Deposited {string.Format("{0:C2}", amount)} for {depositName}");
            Balance += amount;
            TransactionApprovedEvent?.Invoke(this, depositName);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentName"></param>
        /// <param name="amount"></param>
        /// <param name="backupAccount">If user does not have enough money in their checking account, check to see if they have enough money in the savings account and extract money from there</param>
        /// <returns></returns>
        public bool MakePayment(string paymentName, decimal amount, Account backupAccount = null)
        {
            if (Balance >= amount)
            {
                _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                Balance -= amount;
                TransactionApprovedEvent?.Invoke(this, paymentName);
                return true;
            }
            else
            {
                // Check if customer has savings account
                if (backupAccount != null)
                {
                    // Check if savings account has enough money for the transaction
                    if ((backupAccount.Balance + Balance) >= amount)
                    {
                        decimal amountNeeded = amount - Balance;
                        bool overdraftSucceeded = backupAccount.MakePayment("Overdraft Protection", amountNeeded);

                        if (!overdraftSucceeded)
                        {
                            Console.WriteLine("Something failed with tranferring overdraft from savings account, this should have never executed");
                            return false;
                        }

                        // Put money from savings account to checking account and withdraw it. Logic should indicate that end balance ends up as 0
                        AddDeposit("Overdraft Protection Deposit", amountNeeded);
                        _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                        Balance -= amount;
                        TransactionApprovedEvent?.Invoke(this, paymentName);
                        OverdraftEvent?.Invoke(this, amountNeeded);
                        return true;
                    }
                    else
                    {
                        _transactions.Add($"Failed to withdraw {string.Format("{0:C2}", amount)} for {paymentName}, neither checkings nor savings accounts have sufficient funds");
                        TransactionApprovedEvent?.Invoke(this, paymentName);
                        return false;
                    }
                }
                else
                {
                    _transactions.Add($"Failed to withdraw {string.Format("{0:C2}", amount)} for {paymentName}");
                    TransactionApprovedEvent?.Invoke(this, paymentName);
                    return false;
                }

            }
        }
    }
}
