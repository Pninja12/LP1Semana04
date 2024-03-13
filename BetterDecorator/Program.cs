using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private static string Decor (string s , char c ,int i)
        {
            string final = "";
            for(int n = 0; n < i; n++)
            {
                final += $"{c}";
            }
            final += $" {s} ";
            for(int n = 0; n < i; n++)
            {
                final += $"{c}";
            }
            return (final);
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0],char.Parse(args[1]),int.Parse(args[2])));
        }
    }
}
