using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class People
    {
        public IList<Person> PeopleList { get; private set; } = new List<Person>();

        public void Add(Person person)
        {
            PeopleList.Add(person);
        }

        public static People operator +(People p1, People p2)
        {
            var result = new People();

            if (p1.PeopleList.Count != p2.PeopleList.Count)
                throw new ArgumentException("The both object should have the same size.");


            for (int i = 0; i < p1.PeopleList.Count; i++)
            {
                var combinedAge = p1.PeopleList[i].Age + p2.PeopleList[i].Age;
                result.PeopleList.Add(new Person(combinedAge));
            }

            return result;

        }
    }
}
