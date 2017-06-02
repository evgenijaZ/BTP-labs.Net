using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab1
{
    class Graph
    {
        private int m;
        private int n;
        ArrayList used;
        ArrayList edges = new ArrayList();

        public void Read() {
            Console.WriteLine("Enter number of edges");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter edges as: x1 x2 weight");
            for (int i = 0; i < m; i++) {
                int[] values = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
                if (values.Length != 3)
                {
                    Console.WriteLine("Check the format of the line you typed\nIt should be like \"x1 x2 weight\"");
                    i--;
                }
                else {
                    this.edges.Add(new Edge(values[0], values[1], values[2]));
                }
            }

        }

        public void PrintList() {
            Console.WriteLine("Graph: ");
            for (int i = 0; i < edges.Count; i++) {
                Console.WriteLine(edges[i].ToString());
            }
        }

        public void PrintMatrix()
        {
            Console.WriteLine("Graph: ");

            n = GetN();
            n++;
            int[,] matrix = new int[n, n];

            for (int i = 0; i < edges.Count; i++)
            {
                matrix[((Edge)edges[i]).X1, ((Edge)edges[i]).X2] = ((Edge)edges[i]).Weight;
            }
            Console.Write(" \t");
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + "\t");
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("-\t");
                    }
                }
                Console.WriteLine();
            }
        }

        public int GetN()
        {
            int n = 0;
            for (int i = 0; i < edges.Count; i++)
            {
                if (((Edge)edges[i]).X1 > n) n = ((Edge)edges[i]).X1;
                if (((Edge)edges[i]).X2 > n) n = ((Edge)edges[i]).X2;
            }
            return n;
        }


    }
}
