// See https://aka.ms/new-console-template for more information
/* 
Console.WriteLine("Hello, brave new World!");
Console.WriteLine("Feature branch 1 - development 1");
Console.WriteLine("Feature branch 1 - development 2");
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input Transaction Nominal:");
            var TransNominal = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please input Trade Price:");
            var TradePrice = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Is transaction type Buy or Sell?");
            TransactionType trcType;
            var userInput = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            var currentValue = (int)trcType * TransNominal * TradePrice;
            Console.WriteLine($"Your Current value is {currentValue}!");

        }
    }
}