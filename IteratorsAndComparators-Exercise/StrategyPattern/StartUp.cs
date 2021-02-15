using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<Person> peopleByName = new SortedSet<Person>(new PersonByName());
            SortedSet<Person> peopleByAge = new SortedSet<Person>(new PersonByAge());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                peopleByName.Add(person);
                peopleByAge.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, peopleByName));
            Console.WriteLine(string.Join(Environment.NewLine, peopleByAge));
        }
    }
}
