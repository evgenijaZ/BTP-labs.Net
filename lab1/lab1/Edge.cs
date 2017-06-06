using System;
using System.Collections.Generic;

namespace lab1
{ 
    class Edge
    {
        private int x1;
        private int x2;
        private int weight;
      

        public int X1
        {
            get
            {
                return x1;
            }
            set
            {
                x1 = value;
            }
        }
        public int X2
        {
            get
            {
                return x2;
            }
            set
            {
                x2 = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public Edge(int x1, int x2,  int weight) {
            this.X1 = x1;
            this.X2 = x2;
            this.Weight = weight;
        }


        public override String ToString()
        {
            return String.Format("{0}, {1}; - {2}", x1, x2, weight);
        }
    }
}
