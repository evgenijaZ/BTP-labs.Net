using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class EquilateralTriangle : Triangle
    {
     
        public override double Perimeter()
        {
            return this.SideA * 3;
        }

        public override double Square()
        {
            return Math.Pow(this.SideA, 2) * Math.Pow(3, 0.5) / 4;
        }
    }
}
