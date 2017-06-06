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
        public event MethodContainer onRemove;

        public void Add(Object obj) {
            if (obj == null)
            {
                 throw new ArgumentNullException("Argument can`t be null");
            }

            Triangle t = obj as Triangle;
            if ((System.Object)t == null)
            {
                throw new ArgumentNullException("Argument can`t be null");
            }

            figures.Add(t);
            onAdd?.Invoke("\nAdded new element\n" + t.ToString()+"\n");
        }

        public bool Remove(Triangle t) {
            bool result = figures.Remove(t);
            if (result) onRemove?.Invoke("\nRemoved element\n" + t.ToString());
            return result;
        }

        public void RemoveAt(int index)
        {
            if (index >= figures.Count)
                throw new MyIndexOutOfRangeException("Index (" + index + ") can`t be out of range ( size="+figures.Count+" )");
            figures.RemoveAt(index);
            onRemove?.Invoke("\nRemoved element at "+index);
            
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
