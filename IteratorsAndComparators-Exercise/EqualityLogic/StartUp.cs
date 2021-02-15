using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            HashSet<Person> peopleByHash = new HashSet<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                sortedPeople.Add(person);
                peopleByHash.Add(person);
            }

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(peopleByHash.Count);
        }
    }
}
