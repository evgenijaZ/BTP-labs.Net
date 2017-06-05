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

    }
}
