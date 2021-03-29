using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main()
        {
            var checker = new Checker(new Parser(4, 8));
            string input;

            while (true)
            {
                Console.Write("Number: ");
                try
                {
                    input = Console.ReadLine();
                    if (input.Length % 2 == 1)
                    {
                        input = "0" + input;
                    }

                    Console.WriteLine($"Number {input} is{(checker.IsNumberLucky(input) ? string.Empty : " not")} lucky.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
