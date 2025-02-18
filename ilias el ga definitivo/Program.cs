using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilias_el_ga_definitivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "{(})";
            if(IsValid(s)) Console.WriteLine("ilias es verdadero");
            else Console.WriteLine("ilias es falso");
            Console.ReadLine();
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{'|| s[i] == '(' || s[i] == '[' )
                 stack.Push(s[i]);

                if (s[i] == '}')
                {
                    if (stack.Count > 0 && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false; // Si no hay '{' para cerrar, la cadena no es válida
                    }
                }

                if (s[i] == ')')
                {
                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false; // Si no hay '{' para cerrar, la cadena no es válida
                    }
                }

                if (s[i] == ']')
                {
                    if (stack.Count > 0 && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false; // Si no hay '{' para cerrar, la cadena no es válida
                    }
                }
            }

            string resultado = string.Concat(stack);
            Console.WriteLine(resultado); 

            if (resultado == "") return true;

                return false;
        }
    }
}
