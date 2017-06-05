using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class IsoscelesTriangle : Triangle
    {
        public override double Perimeter()
        {
            return this.SideA * 2 + 2 * this.SideA * Math.Sin(this.Angle / 2);
        }

        public override double Square()
        {
            return Math.Pow(this.SideA, 2) * 0.5 * Math.Sin(this.Angle);
        }
    }
}
