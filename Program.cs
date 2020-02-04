using System;
using System.Collections.Generic;

namespace BlowUpMemory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NewMethod();

            var memory = GC.GetTotalMemory(true);

            Console.WriteLine(memory);

            Console.ReadKey();
        }

        private static void NewMethod()
        {
            List<Person> people1, people2, people3, people4, people5;

            people1 = MockPeople(10000000);

            var memory = GC.GetTotalMemory(true);

            if (memory < 2000000000)
            {
                people2 = MockPeople(10000000);
            }

            memory = GC.GetTotalMemory(true);

            if (memory < 2000000000)
            {
                people3 = MockPeople(10000000);
            }

            memory = GC.GetTotalMemory(true);

            if (memory < 2000000000)
            {
                people4 = MockPeople(10000000);
            }

            memory = GC.GetTotalMemory(true);

            if (memory < 2000000000)
            {
                people5 = MockPeople(10000000);
            }

            Console.WriteLine(memory);

            //GC.Collect();
        }

        private static List<Person> MockPeople(int quantity)
        {
            List<Person> people = null;

            if (quantity > 0)
            {
                people = new List<Person>();

                for (int i = 0; i < quantity; i++)
                {
                    people.Add(new Person(i, $"name{i}", $"surname{i}"));
                }
            }

            return people;
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SomeProp1 { get; set; }
        public string SomeProp2 { get; set; }
        public string SomeProp3 { get; set; }
        public string SomeProp4 { get; set; }
        public string SomeProp5 { get; set; }
        public string SomeProp6 { get; set; }
        public string SomeProp7 { get; set; }
        public string SomeProp8 { get; set; }
        public string SomeProp9 { get; set; }
        public string SomeProp10 { get; set; }

        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}