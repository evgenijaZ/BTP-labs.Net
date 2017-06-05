using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Picture
    {
        private List<Triangle> figures = new List<Triangle>();

        public delegate void MethodContainer(String message);
        public event MethodContainer onAdd;

        public void Add(Triangle t) {
            figures.Add(t);
            onAdd?.Invoke("____________________________________\nAdded new element\n" + t.ToString());
        }

       
        public override string ToString()
        {
            String result = "";
            foreach(Triangle t in figures){
                result += t.GetType() + " {\n" + t.ToString() + " }\n";
            }
            return result;
        }

        public double TotalSquare() {
            double result = 0;
            foreach (Triangle t in figures)
            {
               result += t.Square();
            }
                return result;
        }
       
    }
}
