using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>() {
                new Person("Swagat","Active","01/03/2017"),
                new Person("Swagat","InActive","01/03/2018"),
                new Person("Swagat","Deleted","04/05/2018")
            };
            // OUTPUT - Name - Swagat, Status - Active, StartDate - 01/03/2017, EndDate - 12/31/2018
            // OUTPUT - Name - Swagat, Status - InActive, StartDate - 01/03/2018, EndDate - 04/04/2018
            // OUTPUT - Name - Swagat, Status - Deleted, StartDate -  04/04/2018, EndDate - 04/19/2019 (Today)
            Console.ReadKey();
        }
    }

    public class Person
    {
        public Person(string name, string status, string startDate)
        {
            Name = name;
            Status = status;
            StartDate = Convert.ToDateTime(startDate);
        }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
    }
}
