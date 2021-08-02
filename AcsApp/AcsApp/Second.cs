// AcsApp -- A C# App for Git experiments -- 8:17 PM 8/1/2021

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
    } // end class Program

} // end namespace AcsApp
