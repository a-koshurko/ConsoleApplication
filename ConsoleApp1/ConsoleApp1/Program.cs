using System;
using MessageLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? number = null;
            Nullable<int> number1 = null;
            Console.WriteLine((number ?? 0) + ", " + (number1 ?? 0));
            Console.ReadKey();



            /* Console.WriteLine("Hello World!");
             Messenger m = new Messenger();
             string value = m.GetMessage();
             Console.WriteLine(value);
           
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            var lastName = Console.ReadLine();

            Console.WriteLine("PLease enter your work experience in years:");
            var yearsOfExp = Convert.ToByte(Console.ReadLine());

            var currency = Currency.JPY;

            Console.WriteLine($"Hello {name} {lastName}! Your years of experience are {yearsOfExp}. Selcted currency is {currency}");

             */
        }
    }
}
