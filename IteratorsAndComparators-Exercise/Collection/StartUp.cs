using System;
using System.Linq;

namespace Collection
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split().Skip(1).ToArray();

            CustomListyIterator<string> list = new CustomListyIterator<string>(data);

            string input = Console.ReadLine();
            while (input != "END")
            {
                switch (input)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "PrintAll":

                        foreach (var item in list)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
