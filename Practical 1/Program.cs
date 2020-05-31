/*  Practical 1:
    Write C# code to display the asterisk pattern as shown below: 
    ***** 
    ***** 
    ***** 
    ***** 
    ***** 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rectangle");
            Pattern1();

            Console.WriteLine("\nLeft aligned triangle");
            Pattern2();

            Console.WriteLine("\nLeft aligned inverse triangle");
            Pattern3();

            Console.WriteLine("\nRight aligned triangle");
            Pattern4();

            Console.WriteLine("\nRight aligned inverse triangle");
            Pattern5();

            Console.WriteLine("\nCenter aligned triangle");
            Pattern6();

            Console.WriteLine("\nDiamond");
            Pattern7();

            Console.Read();
        }
        /// <summary>
        /// This will print a diamond
        /// </summary>
        private static void Pattern7()
        {
            for (int i = 1; i <= 11; i += 2)
            {
                for (int k = 0; k < 5 - i / 2; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 11; i > 0; i -= 2)
            {
                for (int k = 0; k < 5 - i / 2; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This will print center aligned triangle
        /// </summary>
        private static void Pattern6()
        {
            for (int i = 1; i <= 11; i += 2)
            {
                for (int k = 0; k < 5 - i / 2; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This will print right aligned inverse triangle
        /// </summary>
        private static void Pattern5()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int k = 0; k < 5 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This will print right aligned triangle
        /// </summary>
        private static void Pattern4()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 0; k < 5 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// this will print left aligned inverse triangle
        /// </summary>
        private static void Pattern3()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// This will print left aligned triangle
        /// </summary>
        private static void Pattern2()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// This will print a rectangle 
        /// </summary>
        private static void Pattern1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
