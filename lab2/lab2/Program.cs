using System;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Menu m = new Menu();
            m.ProcessSelectedItem();
        }
    }
}
