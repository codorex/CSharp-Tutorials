using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        public string AccountName { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountName, double balance)
        {
            this.Balance = balance;
            this.AccountName = accountName;
        }

        public double CheckBalance()
        {
            return this.Balance;
        }

        public double Withdraw(double sum)
        {
            if (this.Balance >= sum && sum > 0)
            {
                this.Balance -= sum;
                Console.WriteLine("Balance after withdrawal: {0}$", this.Balance);
                return sum;
            }
            else
            {
                Console.WriteLine("Not enough money in your bank account!\n--Current balance: {0}$\n--Requested sum: {1}$\n--Difference: -{2}$", this.Balance, sum, sum - this.Balance);
                return 0;
            }
        }

        public void Deposit(double sum)
        {
            if (sum > 0)
            {
                this.Balance += sum;
                Console.WriteLine("Balance after deposit: {0}$", this.Balance);
            }
            else
            {
                Console.WriteLine("Cannot deposit negative value!");
            }
        }
    }
}
