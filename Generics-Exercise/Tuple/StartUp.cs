using System;

namespace Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();

            string fullName = personInfo[0] + " " + personInfo[1];
            string town = personInfo[2];

            string[] beerInfo = Console.ReadLine().Split();

            string name = beerInfo[0];
            int liters = int.Parse(beerInfo[1]);

            string[] specialNumbers = Console.ReadLine().Split();

            int specialInt = int.Parse(specialNumbers[0]);
            double specialDouble = double.Parse(specialNumbers[1]);

            CustomTuple<string, string> personTuple = new CustomTuple<string, string>(fullName, town);

            Console.WriteLine(personTuple);

            CustomTuple<string, int> beerTuple = new CustomTuple<string, int>(name, liters);

            Console.WriteLine(beerTuple);

            CustomTuple<int, double> numberTuple = new CustomTuple<int, double>(specialInt, specialDouble);

            Console.WriteLine(numberTuple);
        }
    }
}
