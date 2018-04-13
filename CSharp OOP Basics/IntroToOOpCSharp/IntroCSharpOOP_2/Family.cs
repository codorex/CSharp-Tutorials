using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharpOOP_2
{
    public class Family
    {
        private List<Person> members = new List<Person>();

        public List<Person> Members
        {
            get
            {
                return members;
            }
            private set
            {
                members = value;
            }
        }

        public void Add(Person member)
        {
            members.Add(member);
        }

        public void Exterminate(Person plebToExterminate)
        {
            members.Remove(plebToExterminate);
        }
    }
}
