using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical1
{
    class Program
    {
        public static void pattern1()
            {
            for(int i=0;i<=5;i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
           
            }

        public static void pattern2()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
        }

        public static void pattern3()
        {
            for (int i = 5; i>=0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for(int k=5;k>=i;k--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
        }


        public static void pattern4()
        {
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k >= i; k--)
                {
                    Console.Write("*");
                }
               
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = 5; i >= 0; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                
                Console.Write("\n");
                
            }
            

       }




        static void Main(string[] args)
        {
            
            pattern1();
            Console.Write("\n");
            pattern2();
            Console.Write("\n");
            pattern3();
            Console.Write("\n");
            pattern4();
            Console.Read();



        }     
    }
}
