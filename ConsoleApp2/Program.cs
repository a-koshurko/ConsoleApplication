using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
Add new console application to your solution. Change the startup project.
Add a code (inside Main method) that asks three numbers from a user and stores them into the variables.
Write code that calculates and writes to the console the sum, product and average value.
Add code for comparing the first and the second number. Print “true” to the console if the first number is bigger or equals to the second.
*/

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 3 digits");
            var firstNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Second:");
            var secondNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Third:");
            var thirdNum = Int32.Parse(Console.ReadLine());

            var sum = firstNum + secondNum + thirdNum;
            var product = firstNum * secondNum * thirdNum;
            var average = sum / 3f;
            bool lastTask = firstNum > secondNum;

            Console.WriteLine($"The sum is {sum}, \r\nThe product is {product}, \r\nThe average is {average}");
            Console.WriteLine($"Is the first number is bigger than the second? {lastTask}!");

            int x = 10;
            int y = 12;
            int z = 3;

            int maxValue = (x > y) ? x : y;


            x += y - x++ * z;
            y /= x + 5 % z;

            /*
            Declare and initiate three variables int x = 10, y = 12, z = 3.
            Using the ternary operator write a statement which finds a max value between x and y. 
            Execute following statements one by one. Think about the order of execution prior running them and calculate the result on your own before execution. 
            */


        }
    }
}
