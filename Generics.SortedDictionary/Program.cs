using System;
using System.Collections.Generic;

namespace Generics.SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new SortedDictionary<string, SortedSet<Person>>();
            people.Add("scienct", new SortedSet<Person>(new PersonComparer()));
            people["scienct"].Add(new Person("Swagat"));
            people["scienct"].Add(new Person("Rakesh"));
            people["scienct"].Add(new Person("Abinash"));
            people["scienct"].Add(new Person("Abinash"));


            people.Add("math", new SortedSet<Person>(new PersonComparer()));
            people["math"].Add(new Person("Naibedya"));
            people["math"].Add(new Person("Disha"));
            people["math"].Add(new Person("Gayatri"));
            people["math"].Add(new Person("Gayatri"));


            foreach (var d in people)
            {
                Console.WriteLine($"{d.Key}");
                foreach (var item in d.Value)
                {
                    Console.WriteLine($"\t{item.FirstName}");
                }
            }

            Console.ReadKey();

        }
    }
    public class PersonComparer : IEqualityComparer<Person>, IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return string.Compare(x.FirstName, y.FirstName);
        }

        public bool Equals(Person x, Person y)
        {
            return string.Equals(x.FirstName, y.FirstName);
        }

        public int GetHashCode(Person obj)
        {
            return obj.FirstName.GetHashCode();
        }
    }
    public class Person
    {
        public Person(string name)
        {
            FirstName = name;
        }
        public string FirstName { get; set; }
    }
}
