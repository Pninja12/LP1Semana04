using System;

namespace BetterDecorator
{
    /// <summary>
    /// Programa que recebe 3 parâmetros e imprime-os de acordo com a função 
    /// Decor, imprime um char no ínicio e no fim um número de int vezes com uma
    /// string no meio.
    /// Porém caso não receba 3 parâmetros, imprime outra coisa
    /// </summary>
    class Program
    {
        /// <summary>
        /// Função Decor e recebe uma string, um char e um int e envia o char
        /// repetido um número int de vezes no fim e no início e no meio mete a
        /// string
        /// </summary>
        /// <param name="s">String recebida para imprimir no meio da
        /// frase</param>
        /// <param name="c">Char recebido para imprimir um número de vezes no
        /// início e fim da string</param>
        /// <param name="i">Int recebido para repetir o char</param>
        /// <returns>Uma string</returns>
        private static string Decor (string s , char c ,int i)
        {
            string final = "";//Criação da string a ser enviada no fim

            //Loop para o inicio da string
            for(int n = 0; n < i; n++)
            {
                final += $"{c}";
            }

            //String do meio da string
            final += $" {s} ";

            //Loop para o fim da string
            for(int n = 0; n < i; n++)
            {
                final += $"{c}";
            }
            return (final);
            
        }

        /// <summary>
        /// Caso o Decor anterior não tenha parâmetros suficentes, correste esta
        /// fução ao invés  
        /// </summary>
        /// <returns></returns>
        private static string Decor()
        {
            return (Decor("User did not specify args !", '=', 3));
        }

        /// <summary>
        /// Main que recebe 3 parâmetros e envia para uma função para 
        /// receber uma string e imprimi-la, caso não receba esses parâmetros,
        /// imprime outra coisa
        /// </summary>
        /// <param name="args">Recebe 3 parâmetro, 1 string, 1 char e 
        /// 1 int</param>
        static void Main(string[] args)
        {
            if (args.Length == 3)
                Console.WriteLine(Decor(args[0], char.Parse(args[1])
            , int.Parse(args[2])));
            else
                Console.WriteLine(Decor());
        }
    }
}