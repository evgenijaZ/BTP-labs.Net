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


        public EquilateralTriangle(double a)
        {
            this.SideA = a;
            this.SideB = a;
            this.Angle = 1.04719755;
        }

        public override string ToString()
        {
            return "SideA = " + SideA + "\nSideB = " + SideB + "\nAngle = " + Angle;
        }

        public static EquilateralTriangle operator +(EquilateralTriangle par1, Triangle par2)
        {
            return new EquilateralTriangle(par1.SideA + par2.SideA);
        }

        public static EquilateralTriangle operator -(EquilateralTriangle par1, Triangle par2)
        {
            if (par1.SideA != par2.SideA)
                return new EquilateralTriangle(Math.Abs(par1.SideA - par2.SideA));
            else
                return null;
        }

        public static EquilateralTriangle operator *(EquilateralTriangle par1, Triangle par2)
        {
            return new EquilateralTriangle(par1.SideA * par2.SideA);
        }

        public static EquilateralTriangle operator /(EquilateralTriangle par1, Triangle par2)
        {
            if (par2.SideA == 0)
                throw new MyDivideByZeroException("You try to devide by zero");
            return new EquilateralTriangle(par1.SideA / par2.SideA);
        }
    }
}
