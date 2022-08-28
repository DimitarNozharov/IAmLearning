using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningByExamplesRepo
{
    class Program
    {
        static void Main(string[] args)
        {

            var mix = new object[] { 1, 2, "text", new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3, 4 }, 'c', 1.5d, 1m };
            var people = new List<Person>()
            {
                new Person("Sara", 25, 165, Gender.Female),
                new Person("Ana", 31, 167, Gender.Female),
                new Person("Ana", 44, 172, Gender.Female),
                new Person("Mark", 22, 180, Gender.Male),
                new Person("Strange", 33, 166, Gender.Other)
            }; 

            var peopleWithCondition = people
                .Where(x => x.Name.Length == 4)
                .OrderBy(x => x.Name).ThenBy(x => x.Age)
                .Select(x => x.Name);

            var avarage = people.Average(x => x.Age);
            var min = people.Min(x => x.Age);
            var max = people.Max(x => x.Age);
            var total = people.Sum(x => x.Age);
            Console.WriteLine($"Avarage age: {avarage}\nMin age: {min}\nMax age:{max}\nTotal: {total}\n");

            var allIntegers = mix.OfType<int>().Where(x => x <3);

            foreach (var item in allIntegers)
            {
                Console.WriteLine(item);
            }

            allIntegers.ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("List starts here:");
            var allIntLists = mix.OfType<List<int>>().ToList();
            for (int i = 0; i < allIntLists.Count; i++)
            {
                Console.WriteLine($"Int list[{i}]: {string.Join(",", allIntLists[i])}");
            }

                    
            //Melee : Character
            //meleeTeam = characters.OfType<Melee>().ToList()
            //meleeTeam = characters.Where(c => c is Melee).Cast<Melee>().ToList();
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public Gender Gender { get; set; }

        public Person(string name, int age, int height, Gender gender)
        {
            this.Age = age;
            this.Name = name;
            this.Height = height;
            this.Gender = gender;
        }
    }

    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2,
        Other = 3
    }
}
