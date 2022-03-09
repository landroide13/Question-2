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
            
            Console.WriteLine("Length " + len);

            Console.WriteLine("Parant " + par);
            Console.WriteLine("square " + sq);
            Console.WriteLine("Curly " + cu);
            Console.WriteLine("Arrows " + ar);

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

            bool isSurroundedParens = false;

            
            if (!isSurroundedParens) 
            {
                Console.WriteLine();
                Console.WriteLine("###### Expresion Incorrect ######");
            }

        }
    }
}
