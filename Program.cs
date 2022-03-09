using System;
using System.Collections;

namespace ExpresionValidation
{
    class Program
    {
        static void displayStack(Stack s)
        {
            foreach(char i in s)
            {
                Console.Write(i + " ");
            }
        }
        static string getExpression()
        {
            Console.WriteLine();
            Console.WriteLine("########### Please Enter the Expression between () , [], {}, <> #############");
            Console.WriteLine();

            string expression = Console.ReadLine();

            return expression;
        }

        static void setScore(int pa, int sq, int cu, int ar)
        {
            if( (pa % 2) == 0 || (sq % 2) == 0 || (cu % 2) == 0 || (ar % 2) == 0)
            {
                Console.WriteLine("The Expression is Correct !!");
            }
            else
            {
                Console.WriteLine("The Expression is INCorrect !!");
            }
        }

        static void checkStack(Stack st)
        {
            int len = st.Count;

            int par = 0;
            int sq = 0;
            int cu = 0;
            int ar = 0;

            foreach(char el in st)
            {
                if(el == '(' || el == ')')
                {
                    par++;
                }

                if(el == '{' || el == '}')
                {
                    cu++;
                }

                if(el == '[' || el == ']')
                {
                    sq++;
                }

                if(el == '<' || el == '>')
                {
                    ar++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Length " + len);
            
            Console.WriteLine();
            setScore(par, sq, cu, ar);

        }
        static void setStack(string s)
        {
            var myExp = new Stack();

            foreach(char i  in s)
            {
                if(i == '(' || i == '[' || i == '{' || i == '<' || i == ')' || i == ']' || i == '}' || i == '>')
                {
                    myExp.Push(i);
                }
            }

            Console.WriteLine();
            displayStack(myExp);

            Console.WriteLine();
            checkStack(myExp);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("########### Welcome to the Expression Validating Program #############");

            string s = getExpression();

            setStack(s);

        }
    }
}
