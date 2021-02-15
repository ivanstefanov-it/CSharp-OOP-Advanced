using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

            CustomStack<string> stack = new CustomStack<string>();

            foreach (var item in data)
            {
                stack.Push(item);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                switch (input)
                {
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        string element = input.Split()[1];
                        stack.Push(element);
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
