using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b, double angle)
        {
            if (angle >= 1.57079633) throw new NegativeValueException("The angle should be less than 1.57079633 radians");
            if (angle <= 0 || angle > 3.1415926535898) throw new NegativeValueException("The angle should be 0 and pi radian");
            if (a < 0) throw new NegativeValueException("The side A should be positive"); 
            if (b < 0) throw new NegativeValueException("The side B should be positive");
            this.SideA = a;
            this.SideB = b;
            this.Angle = angle;
        }

        public override double Perimeter()
        {
            return this.SideA + this.SideB + this.SideB *Math.Sin(this.Angle);
        }

        public override double Square()
        {
            return this.SideA * this.SideB * 0.5;
        }

  
        public override string ToString()
        {
            return "SideA = "+SideA+ "\nSideB = " + SideB + "\nAngle = " + Angle;
        }

        public static RightTriangle operator +(RightTriangle par1, Triangle par2)
        {
            return new RightTriangle(par1.SideA + par2.SideA,
                par1.SideB + par2.SideB, par1.Angle + par2.Angle);
        }

        public static RightTriangle operator -(RightTriangle par1, Triangle par2)
        {
            if (par1.SideA != par2.SideA && par1.SideB != par2.SideB && par1.Angle != par2.Angle)
                return new RightTriangle(Math.Abs(par1.SideA - par2.SideA), Math.Abs(par1.SideB - par2.SideB), Math.Abs(par1.Angle - par2.Angle));
            else
                return null;
        }

        public static RightTriangle operator *(RightTriangle par1, Triangle par2)
        {
            return new RightTriangle(par1.SideA * par2.SideA,
                par1.SideB * par2.SideB, par1.Angle * par2.Angle);
        }

        public static RightTriangle operator /(RightTriangle par1, Triangle par2)
        {
            if (par2.SideA == 0 || par2.SideB == 0 || par2.Angle == 0)
                throw new MyDivideByZeroException("You try to devide by zero");
            return new RightTriangle(par1.SideA / par2.SideA,
                par1.SideB / par2.SideB, par1.Angle / par2.Angle);
        }

    }
}
