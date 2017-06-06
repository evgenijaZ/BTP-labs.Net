using System;

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

        public IsoscelesTriangle(double a, double angle)
        {
            if (a <= 0) throw new NegativeValueException("The side A should be positive");
            if (angle <= 0 || angle > 3.1415926535898) throw new NegativeValueException("The angle should be 0 and pi radian");
            this.SideA = a;
            this.SideB = a;
            this.Angle = angle;
        }

        public override string ToString()
        {
            return "SideA = " + SideA + "\nSideB = " + SideB + "\nAngle = " + Angle;
        }

        public static IsoscelesTriangle operator +(IsoscelesTriangle par1, Triangle par2)
        {
            return new IsoscelesTriangle(par1.SideA + par2.SideA,
                 par1.Angle + par2.Angle);
        }

        public static IsoscelesTriangle operator -(IsoscelesTriangle par1, Triangle par2)
        {
            if (par1.SideA != par2.SideA && par1.Angle != par2.Angle)
                return new IsoscelesTriangle(Math.Abs(par1.SideA - par2.SideA), 
                    Math.Abs(par1.Angle - par2.Angle));
            else
                return null;
        }

        public static IsoscelesTriangle operator *(IsoscelesTriangle par1, Triangle par2)
        {
            return new IsoscelesTriangle(par1.SideA * par2.SideA,
                par1.Angle * par2.Angle);
        }

        public static IsoscelesTriangle operator /(IsoscelesTriangle par1, Triangle par2)
        {
            if (par2.SideA == 0 || par2.Angle == 0)
                throw new MyDivideByZeroException("You try to devide by zero");
            return new IsoscelesTriangle(par1.SideA / par2.SideA,
                par1.Angle / par2.Angle);
        }




    }
}
