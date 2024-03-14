using System;

namespace BetterDecorator
{
    class Program
    {
        private static string Decor()
        {
            return Decor("User did not specify args!", '=',3);
        }

        /// <summary>
        /// Agrupa certo numeros de caracters entre a frase.
        /// </summary>
        /// <param name="s"> Aqui recebe a frase. </param>
        /// <param name="dec"> Recebe o caractere. </param>
        /// <param name="num"> Numero de caracteres. </param>
        /// <returns> caracteres entre a frase. </returns>
        private static string Decor(string s, char dec, int num)
        {
            string agrupar = new string(dec,num);
            return $"{agrupar} {s} {agrupar}";
        }

        /// <summary>
        /// No main é verificado primeiro quantos argumentos o utilizador
        /// colocou chamada a função Decor() com 3 parametros string,
        /// char e int.
        /// </summary>
        /// <param name="args"> numero de argumentos que o utilizador
        /// escreverá </param>
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                Console.WriteLine(Decor(args[0],char.Parse(args[1]),
                int.Parse(args[2])));
            }
            else
            {
                Console.WriteLine(Decor());
            }
        }
    }
}
