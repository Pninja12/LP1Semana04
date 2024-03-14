using System;

namespace Special
{
    class Program
    {
        private static int GetSpecial(int n)
        {
            if (n <= 0)
                return (-n);
            else
                return GetSpecial(n-1) + 2 * GetSpecial(n-2);
        }
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            Console.WriteLine(GetSpecial(int.Parse(Console.ReadLine()))/2);
        }
    }
}
