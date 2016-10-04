// AcsApp -- A C# App for Git experiments -- 2016 10 02 -- UPDATED from I3847

using System;

namespace AcsApp
{
    partial class Program
    {
        // Main method
        static void Main(string[] args)
        {
            int n;
            Console.Write("\nA C# App:");
            for (int i = 1; i < 21; i++)
                Console.Write(" {0}", i);
            Console.WriteLine("\n");
            AProc();
            n = AFunc();
            Console.WriteLine("n = {0}\n", n);
        }
    }
}
