using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharpOOP_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var peshko = new Person("Pesho", "Toshev", 1);
            var toshko = new Person("Toshko", "Toshev", 13);
            var penka = new Person("Penka", "Tosheva", 12);

            var toshevi = new Family();

            toshevi.Add(peshko);
            toshevi.Add(toshko);
            toshevi.Add(penka);

            foreach (var toshev in toshevi.Members)
            {
                Console.WriteLine(toshev.ToString());
            }
        }
    }
}
