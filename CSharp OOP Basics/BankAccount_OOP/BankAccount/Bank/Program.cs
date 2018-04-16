using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
  public class Program
  {
    static void Main(string[] args)
    {
      List<BankAccount> accounts = new List<BankAccount>()
      {
        new BankAccount("FiBank", 500),
        new BankAccount("UniCredit", 600),
        new BankAccount("DSK", 100)
      };

      Person person = new Person("Peshko Peshev", 18, accounts);
    }
  }
}
