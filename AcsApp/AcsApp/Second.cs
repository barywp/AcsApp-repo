// AcsApp -- A C# App for Git experiments -- 2016 10 02 -- UPDATED from I3847

using System;

namespace AcsApp
{
    partial class Program
    {
        static int AFunc()
        {
            return 41 + 1;
        }

        static void AProc()
        {
            Console.Write("AProc... AFunc -> {0}. ", AFunc());
        }
    }
}
