/* Practical 3: Write C# code to do the  following 
 * a. Convert binary to decimal 
 * b. Convert decimal to hexadecimal 
 * c. Convert decimal to binary 
 * d. Convert decimal to octal
 */
using System;
using System.Text.RegularExpressions;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber;

            #region Binary To Decimal
            bool flag = true;
            string binaryString;

            //Take and validate user input in string format
            Console.WriteLine("Enter a binary number(31 bit Max)");
            do
            {
                if (!flag) //Only execute if user enters anything except 0 and 1
                    Console.WriteLine("Please enter a valid binary value");
                binaryString = Console.ReadLine();
                flag = false; //will display error message in every subsequent iteration of this loop (if this loop continuous)
            } while (!Regex.IsMatch(binaryString, @"^[01]+$")); //Checking input string for anything other than 0s and 1s

            ConvertBinaryToDecimal(binaryString, out decimalNumber);
            Console.WriteLine("Answer: " + decimalNumber);

            #endregion

            #region Decimal To Octal and Binary

            //Declaration and initialisation
            int number, newBase;

            TakeDecimalInput(out decimalNumber);

            Console.WriteLine("In which base you want to convert? (2 or 8)");
            newBase = int.Parse(Console.ReadLine());

            ConvertDecimalToBinaryOrOctal(decimalNumber, out number, newBase);
            Console.WriteLine(number);

            #endregion

            #region Decimal To HexaDecimal
            string hex;
            TakeDecimalInput(out decimalNumber);
            ConvertDecimalToHex(decimalNumber, out hex);
            Console.WriteLine($"Hexadecimal equivalent of {decimalNumber} is {hex}");
            #endregion

            Console.Read();
        }

        #region Conversion Methods

        
        private static void ConvertDecimalToHex(int decimalNumber, out string hex)
        {
            char[] modulo = new char[31]; //To store all the modulos of a decimal mumber after iteratively dividing by 8
            int i = 0, temp;
            hex = "";
            //Find all the modulos and store them in an integer array
            while (decimalNumber > 0)
            {
                temp = (char)(decimalNumber % 16);
                if (temp > 9)
                    modulo[i] = (char)(temp + 55);
                else
                    modulo[i] = (char)(temp+48);
                decimalNumber /= 16;
                i++;
            }

            i--; //decrease by 1 to manage the actual length of the number

            //
            for (; i >= 0; i--)
            {
                hex += modulo[i];
            }
        }

       
        /// <summary>
        /// Converts decimal input to equivalent octal number
        /// </summary>
        /// <param name="decimalNumber">Decimal Number from user</param>
        /// <param name="number">Converted Octal Number will be returned in this variable</param>
        private static void ConvertDecimalToBinaryOrOctal(int decimalNumber, out int number, int newBase)
        {
            number = 0;
            int[] modulo = new int[31]; //To store all the modulos of a decimal mumber after iteratively dividing by 8
            int i = 0;
            string numberString = ""; //To form a single string of all the modulos togather

            //Find all the modulos and store them in an integer array
            while(decimalNumber>0)
            {
                modulo[i++] = decimalNumber % newBase;
                decimalNumber /= newBase;
            }

            i--; //decrease by 1 to manage the actual length of the number

            //
            for (; i >= 0 ; i--)
            {
                numberString += modulo[i].ToString();
            }
            number = int.Parse(numberString);
        }

        /// <summary>
        /// Converts a string of 0s and 1s to equivalent decimal number
        /// </summary>
        /// <param name="binaryString">string of 0s and 1s</param>
        /// <param name="decimalNumber">store the converted decimal number</param>
        private static void ConvertBinaryToDecimal(string binaryString, out int decimalNumber)
        {
            //Variable declaration and initialisation
            decimalNumber = 0; //To store converted decimal number
            int bit; //to store individual bit from right to left while calculating decimal from binary
            int powerCounter = 0; //To manage the exponent of 2
           
            //Convertion of Binary to Decimal
            for (int i = binaryString.Length - 1; i >= 0; i--)
            {
                bit = int.Parse(binaryString[i].ToString());
                decimalNumber += bit * (int)Math.Pow(2, powerCounter++);
            }
        }
        #endregion

        #region Helper Method
        /// <summary>
        /// Prompt user to input decimal number
        /// </summary>
        /// <param name="decimalNumber"></param>
        /// <param name="numberString"></param>
        private static void TakeDecimalInput(out int decimalNumber)
        {
            string numberString;
            bool flag = true; //to display error message while user enters invalid binary/decimal number

            //Take and validate user input
            Console.Write("Enter Decimal Number: ");
            do
            {
                if (!flag) //only execute if user have entered invalid decimal number
                    Console.WriteLine("Please enter a valid decimal number");
                numberString = Console.ReadLine();
                flag = false; //will display error message in every subsequent iteration of this loop (if this loop continuous)
            } while (!int.TryParse(numberString, out decimalNumber));
        }

        #endregion
    }
}
