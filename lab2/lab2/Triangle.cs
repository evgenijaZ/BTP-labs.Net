using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Triangle
    {
        private double sideA;
        private double sideB;
        private double angle;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        abstract public double Square();
        abstract public double Perimeter();


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

        public static bool operator ==(Triangle par1, Triangle par2) {
            if (System.Object.ReferenceEquals(par1, par2))
            {
                return true;
            }

            if (((object)par1 == null) || ((object)par2 == null))
            {
                return false;
            }

            return (par1.SideA == par2.SideA) && (par1.SideB == par2.SideB) && (par1.Angle == par2.Angle);
        }

        public static bool operator !=(Triangle par1, Triangle par2)
        {
            return !(par1 == par2);
        }

        public override int GetHashCode()
        {
            return SideA.GetHashCode() ^ SideB.GetHashCode() ^ Angle.GetHashCode();
        }
    }
}
