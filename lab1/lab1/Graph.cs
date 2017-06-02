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
        private int m = 0;
        private int n = 0;
        List<Edge> edges = null;
        int[,] matrix = null;

        List<Edge> MST = new List<Edge>();

        public void Read()
        {
            edges = new List<Edge>();
            Console.WriteLine("Enter number of edges");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter edges as: x1 x2 weight");
            for (int i = 0; i < m; i++)
            {
                int[] values = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
                if (values.Length != 3)
                {
                    Console.WriteLine("Check the format of the line you typed\nIt should be like \"x1 x2 weight\"");
                    i--;
                }
                else
                {
                    this.edges.Add(new Edge(values[0], values[1], values[2]));
                }
            }
            n = GetN();
        }

        public void PrintList()
        {
            Console.WriteLine("Edges: ");
            for (int i = 0; i < edges.Count; i++)
            {
                Console.WriteLine(edges[i].ToString());
            }
        }

        private void FillMatrix()
        {
            if (edges != null)
            {
                if (n == 0) n = GetN();
                matrix = new int[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        matrix[i, j] = short.MaxValue;

                for (int i = 0; i < edges.Count; i++)
                {
                    matrix[(edges[i]).X2, (edges[i]).X1] = (edges[i]).Weight;
                    matrix[(edges[i]).X1, (edges[i]).X2] = (edges[i]).Weight;
                }

            }
            else
            {
                Console.WriteLine("Insufficient data to fill the matrix");
                return;
            }
        }


        public void PrintMatrix(String del)
        {
            FillMatrix();
            Console.WriteLine("Graph: ");
            Console.Write(" "+ del);

            for (int i = 0; i < n; i++)
                Console.Write(i + del);

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + del);
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] != short.MaxValue)
                        Console.Write(matrix[i, j] + del);
                    else
                        Console.Write("-" + del);
                }
                Console.WriteLine();
            }
        }

        public int GetN()
        {
            int n = 0;
            for (int i = 0; i < edges.Count; i++)
            {
                if (((Edge)edges[i]).X1 > n)
                    n = ((Edge)edges[i]).X1;
                if (((Edge)edges[i]).X2 > n)
                    n = ((Edge)edges[i]).X2;
            }
            if (n != 0) n++;
            return n;
        }

        public void PrintMST()
        {
            MSTree();
            if (MST == null) return;
            Console.WriteLine("Maximum spanning tree:");
            for (int i = 0; i < MST.Count; i++)
            {
                Console.WriteLine(MST[i].ToString());
            }

        }


        private void MSTree()
        {
            if (n == 0) return;
            List<int> usedV = new List<int>();
            List<int> notUsedV = new List<int>();
            List<Edge> notUsedE = new List<Edge>(this.edges);
            for (int i = 0; i < n; i++)
                notUsedV.Add(i);

            Random rand = new Random();
            usedV.Add(rand.Next(0, n));
            notUsedV.RemoveAt(usedV[0]);
            while (notUsedV.Count > 0)
            {
                int maxE = -1;
                for (int i = 0; i < notUsedE.Count; i++)
                {
                    if ((usedV.IndexOf(notUsedE[i].X1) != -1) && (notUsedV.IndexOf(notUsedE[i].X2) != -1) ||
                        (usedV.IndexOf(notUsedE[i].X2) != -1) && (notUsedV.IndexOf(notUsedE[i].X1) != -1))
                    {
                        if (maxE != -1)
                        {
                            if (notUsedE[i].Weight > notUsedE[maxE].Weight)
                                maxE = i;
                        }
                        else
                            maxE = i;
                    }
                }

                if (usedV.IndexOf(notUsedE[maxE].X1) != -1)
                {
                    usedV.Add(notUsedE[maxE].X2);
                    notUsedV.Remove(notUsedE[maxE].X2);
                }
                else
                {
                    usedV.Add(notUsedE[maxE].X1);
                    notUsedV.Remove(notUsedE[maxE].X1);
                }

                MST.Add(notUsedE[maxE]);
                notUsedE.RemoveAt(maxE);
            }

        }
    }
}
