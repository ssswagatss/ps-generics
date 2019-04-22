using System;
using System.Collections.Generic;

namespace Generics.SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new SortedDepartmentCollection();
            people.Add("scienct", "Swagat")
                  .Add("scienct", "Rakesh")
                  .Add("scienct", "Abinash")
                  .Add("scienct", "Abinash");

            people.Add("math", "Naibedya")
                  .Add("math", "Disha")
                  .Add("math", "Gayatri")
                  .Add("math", "Gayatri");
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

    public class SortedDepartmentCollection : SortedDictionary<string, SortedSet<Person>>
    {
        public SortedDepartmentCollection Add(string dept, string name)
        {
            if (!this.ContainsKey(dept))
                this.Add(dept, new SortedSet<Person>(new PersonComparer()));

            this[dept].Add(new Person(name));
            return this;
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
