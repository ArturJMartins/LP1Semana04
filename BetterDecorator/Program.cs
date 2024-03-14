using System;

namespace BetterDecorator
{
    class Program
    {
        private static string Decor(string s, char dec, int num)
        {
            string agrupar = new string(dec,num);
            return $"{agrupar} {s} {agrupar}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0],char.Parse(args[1]),
            int.Parse(args[2])));
        }
    }
}
