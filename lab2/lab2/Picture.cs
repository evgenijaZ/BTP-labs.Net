using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Picture
    {
        public List<Triangle> figures = new List<Triangle>();

        public override string ToString()
        {
            String result = "";
            foreach(Triangle t in figures){
                result += t.GetType() + " {\n" + t.ToString() + " }\n";
            }
            return result;
        }

       
    }
}
