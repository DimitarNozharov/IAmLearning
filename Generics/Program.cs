using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /// <summary>
    /// Generic - reduce the redundant code
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //var text = "abcd";
            // var result = Reverse(text);
            // Console.WriteLine(result);

            People people = new People();
            people.Add(new Person(1));
            people.Add(new Person(4));

            People newPeople = new People();
            newPeople.Add(new Person(11));
            newPeople.Add(new Person(12));

            var combinedPeople = people + newPeople;

            foreach (var p in combinedPeople.PeopleList)
            {
                Console.WriteLine(p);
            }

            var numberComparison = AreEqual(-1, 3);
            Console.WriteLine(numberComparison);

            //invalid
            //var invalidComparison = AreEqual("text", true);

            int[] numbers = { 1, 4, 5, -3, 7, 14, 2, 0, 2 };
            string[] texts = { "say", "something", "1bs", "cat" };
            SortAscending(numbers);
            Console.WriteLine(string.Join(", ", numbers));
           
            SortAscending(texts);
            Console.WriteLine(string.Join(", ", texts));

            var p1 = new Person(2);
            var p2 = new Person(2);
            Console.WriteLine(AreEqual(p1, p2));


        }

        public static string Reverse(string text)
        {

            if (text == null)
                return string.Empty;

            var result = new StringBuilder(text.Length);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result.Append(text[i]);
            }

            return result.ToString(); ;
        }

        public static bool AreEqual<T>(T val1, T val2) where T : IComparable<T>
        {
            return val1.CompareTo(val2) == 0;
        }

        public static void SortAscending<T>(T[] array) where T :  IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[i].CompareTo(array[j]) < 0)
                    {
                        //swap
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

     
    }
}
