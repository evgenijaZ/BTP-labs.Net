using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph a = new Graph();
            a.Read();
            a.PrintList();
            a.PrintMatrix("\t");
            a.PrintMST();
            Console.ReadKey();
        }
    }
}
