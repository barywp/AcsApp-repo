﻿// AcsApp -- A C# App for Git experiments -- 8:17 PM 8/1/2021

using System;

namespace AcsApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("\nA C# App:");
            for (int i = 0; i < 26; i++)
                Console.Write(" {0}", i);
            Console.WriteLine("\n");
            AProc();
            n = AFunc();
            Console.WriteLine("n = {0}\n", n);
        } // end Main()
    } // end class Program

} // end namespace AcsApp
