/* Practical 7: 
 * Write a C# code to Perform Celsius to Fahrenheit Conversion and Fahrenheit to Celsius conversion. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            float centigrade, fahrenheit;
            int choice;
            Console.WriteLine("Give your choice:");
            Console.WriteLine("1. Centigrade to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Centigrade");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //Take temperature in centigrade form user
                    Console.Write("Enter temperature in centigrade(°C):  ");
                    centigrade = float.Parse(Console.ReadLine());

                    //Convert from centigrade to fahrenheit
                    fahrenheit = centigrade * 9 / 5 + 32;
                    Console.WriteLine($"{centigrade}°C = {fahrenheit}°F");
                    break;
                case 2:
                    //Take temperature in fahrenheit form user
                    Console.Write("Enter temperature in fahrenheit(°F):  ");
                    fahrenheit = float.Parse(Console.ReadLine());

                    //Convert from fahrenheit to centigrade
                    centigrade = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"{fahrenheit}°F = {centigrade}°C");
                    break;
            }
            Console.Read();
        }
    }
}
