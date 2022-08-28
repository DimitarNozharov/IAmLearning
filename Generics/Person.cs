using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Person : IComparable<Person>
    {
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            return Age.CompareTo(other?.Age);
        }

        public Person(int age)
        {
            Age = age;
        }
    }
}
