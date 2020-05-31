/* Practical 2
 * Write C# code to prompt a user to input his/her name and country name 
 * and then the output will be shown as an example below: 
 * Hello Ram from country India!
 */
using System;
using System.Text.RegularExpressions;
namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, country;
            do
            {
                Console.WriteLine("Hello! Whats your name?");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name,@"^[a-zA-Z]+$"));
            do
            {
                Console.WriteLine("Where are you from?");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(country,@"^[a-zA-Z]+$"));

            Console.WriteLine($"Hello {name} from country {country}");
            Console.Read();
        }
    }
}
