using System;
using System.ComponentModel;

namespace Special
{
    class Program
    {
        private static int GetSpecial(int n)
        {
            int numero;
            if(n == 0)
            {
                numero = 0;
            }
            else if(n == 1)
            {
                numero = 1;
            }
            else
            {
                numero = GetSpecial(n-1) + (2* GetSpecial(n-2));
            }

            return numero;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSpecial(0));
            Console.WriteLine(GetSpecial(1));
            Console.WriteLine(GetSpecial(2));
            Console.WriteLine(GetSpecial(7));
        }
    }
}
