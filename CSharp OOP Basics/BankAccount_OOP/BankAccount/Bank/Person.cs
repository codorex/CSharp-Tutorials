using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public List<BankAccount> BankAccounts { get; set; }

        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
            this.BankAccounts = new List<BankAccount>();
        }

        public Person(string fullName, int age, List<BankAccount> accounts) : this(fullName, age)
        {
            this.BankAccounts = accounts;
        }
    }
}
