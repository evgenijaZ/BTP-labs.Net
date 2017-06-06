using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Picture p = new Picture();
            RightTriangle t1 = new RightTriangle(5,7,0.26);
            IsoscelesTriangle t2 = new IsoscelesTriangle(3, 0.14);
            EquilateralTriangle t3 = new EquilateralTriangle(6);
            EquilateralTriangle t4 = new EquilateralTriangle(6);
            EquilateralTriangle t5 = new EquilateralTriangle(2);
            IsoscelesTriangle t6 = new IsoscelesTriangle(8, 0.79);
            RightTriangle t7 = new RightTriangle(2, 3, 1.15);

            Handler handler = new Handler();
            p.onAdd += handler.ShowMessage;
            p.onRemove += handler.ShowMessage;
            p.Add(t1); 
            p.Add(t2); 
            p.Add(t3); 
            p.Add(t4); 
            p.Add(t5); 
            p.Add(t6); 
            p.Add(t7);       
            Console.WriteLine(p.TotalSquare());
            Console.ReadKey();
        }
    }
}
