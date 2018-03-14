using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrapper
{
    class Person
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public char Gender { get; set; }

        public Person(string Name, uint Age, char Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        public Person()
        {

        }
    }
}
