// AcsApp -- A C# App for Git experiments -- 2016 10 03 @ 10:43 PM

using System;

namespace AcsApp
{
    partial class Program
    {
        // Main method
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("\nA C# App:");
            Console.Write(" -master- ");    //FOO
            for (int i = 1; i < 21; i++)
                Console.Write(" {0}", i);
            Console.WriteLine("\n");
            AProc();
            n = AFunc();
            Console.WriteLine("\nfourthBranch");
            Console.WriteLine("n = {0}\n", n);
        }
    }
}
