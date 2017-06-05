using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class RightTriangle : Triangle
    {
        public override double Perimeter()
        {
            return this.SideA + this.SideB + this.SideB *Math.Sin(this.Angle);
        }

        public override double Square()
        {
            return this.SideA * this.SideB * 0.5;
        }
    }
}
