using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph a = new Graph();
            a.Read();
            a.PrintList();
            a.PrintMatrix();
            Console.ReadKey();
        }
    }
}
