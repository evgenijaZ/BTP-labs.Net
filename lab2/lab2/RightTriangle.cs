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

        public RightTriangle(double a, double b, double angle) {
            if (angle > 1.57079633) return;
            this.SideA = a;
            this.SideB = b;
            this.Angle = angle;
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
            return new RightTriangle(par1.SideA / par2.SideA,
                par1.SideB / par2.SideB, par1.Angle / par2.Angle);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Triangle t = obj as Triangle;
            if ((System.Object)t == null)
            {
                return false;
            }

            return (SideA == t.SideA) && (SideB == t.SideB) && (Angle == t.Angle);
        }

        public bool Equals(Triangle t)
        {
            if ((object)t == null)
            {
                return false;
            }
            return (SideA == t.SideA) && (SideB == t.SideB) && (Angle == t.Angle);
        }


    }
}
