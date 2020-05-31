/* Practical 4
 * 'Write C# code to convert infix notation to postfix notation. 
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            string infix;
            string postfix;
            infix = "(a^b)/c";
            infixToPostfix(infix, out postfix);
            Console.WriteLine($"Infix Expression {infix}\nPostfix Expression {postfix}");
            Console.Read();

        }
        /// <summary>
        /// Converts given infix expression to equivalent postfix expression
        /// </summary>
        /// <param name="infix">Given infix exoression</param>
        /// <param name="postfix">Equivalent postfix expression converted from infix expression</param>
        private static void infixToPostfix(string infix, out string postfix)
        {
            postfix = "";
            char ch;
            Stack<char> operators = new Stack<char>();

            //Process each character in the expression
            for (int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];
                if ("^()+-*/%".Any(c => c == ch)) //Check for operators
                { 
                    if(operators.Count == 0)
                    {
                        //If the stack is empty than push current operator to the stack
                        operators.Push(ch);
                    }
                    else
                    {
                        if(ch == '(')
                        {
                            operators.Push(ch);
                        }
                        else if(ch == ')')
                        {
                            //Pop all operator from stack to pstfix until you reach '('
                            while(operators.Peek() != '(')
                            {
                                postfix += operators.Pop();
                            }
                            operators.Pop(); //Pop '(' from the stack
                        }
                        else if(priority(ch) > priority(operators.Peek()))
                        {
                            //If new operator has higher priority than top of the stack then push it to the stack
                            operators.Push(ch);
                        }
                        else
                        {
                            //Pop top of the stack to postfix and decrease 'i' to operate same inpur operator in the next itration
                            postfix += operators.Pop();
                            i--;
                        }
                    }
                }
                else 
                {
                    //Add every operand to postfix
                    postfix += ch;
                }
            }

            //Pop all remaining operators from stack to postfix expression
            foreach (var item in operators)
            {
                postfix += item;
            }
        }

        /// <summary>
        /// return the priority of the given operator 
        /// </summary>
        /// <param name="ch">The operator for which we want to find priority</param>
        /// <returns></returns>
        private static int priority(char ch)
        {
            switch (ch)
            {
                case '(':
                    return 0; // Minimum 
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3; //Maximum
                default:
                    return 4; //Should never be executed for a valid infix expression
            }
        }
    }
}
