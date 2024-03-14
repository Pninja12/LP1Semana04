using System;

namespace Special
{
    /// <summary>
    /// Programa que pede ao utilizador um número e mostra o seu correspondente
    /// sobre uma sequência especial
    /// </summary>
    class Program
    {
        /// <summary>
        /// Percebo porquê que funciona mas não conseguiria fazer este código 
        /// sozinho, ainda tenho dificuldade em perceber se fiz da maneira 
        /// correta ou não
        /// </summary>
        /// <param name="n">Recebe o número para retornar o seu
        /// correspondente da sequência</param>
        /// <returns>(O número - 1) + 2 * (O número - 2)</returns>
        private static int GetSpecial(int n)
        {
            if (n <= 0)
                return (-n);
            else
                return GetSpecial(n-1) + 2 * GetSpecial(n-2);
        }
        /// <summary>
        /// Pergunta ao utilizador que número quer e envia para a função
        /// GetSpecial para receber o número da sequência correspondente
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            Console.WriteLine(GetSpecial(int.Parse(Console.ReadLine()))/2);
        }
    }
}
