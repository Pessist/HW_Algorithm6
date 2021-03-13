using System;
using System.Linq;
using System.Collections.Generic;


namespace HW_Algorithm6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vertices = new[] { 1, 2, 3, 4, 5, 6 };
            Tuple<int, int>[] edges = new[]
            {
                Tuple.Create(1, 2),
                Tuple.Create(1, 3),
                Tuple.Create(2, 5),
                Tuple.Create(2, 6),
                Tuple.Create(3, 4),
                Tuple.Create(5, 6),
                Tuple.Create(6, 5)
            };

            Graph graph = new Graph(vertices, edges);

            HashSet<int> BFS = GraphBFS_DFS.BreadthFirstSearch(graph, 1);

            HashSet<int> DFS = GraphBFS_DFS.DepthFirstSearch(graph, 1);

            //Тест выполнения программы
            HashSet<int> bfsTest = new HashSet<int>();
            bfsTest.Add(1);
            bfsTest.Add(2);
            bfsTest.Add(3);
            bfsTest.Add(5);
            bfsTest.Add(6);
            bfsTest.Add(4);

            HashSet<int> dfsTest = new HashSet<int>();
            dfsTest.Add(1);
            dfsTest.Add(3);
            dfsTest.Add(4);
            dfsTest.Add(2);
            dfsTest.Add(6);
            dfsTest.Add(5);

            bool isEqualTestB = Enumerable.SequenceEqual(BFS, bfsTest);
            bool isEqualTestD = Enumerable.SequenceEqual(DFS, dfsTest);

            bool test = isEqualTestB == isEqualTestD;

            if (test)
            {
                Console.WriteLine($"Проветка BSF - {isEqualTestB};\nПроветка DSF - {isEqualTestD};");
            }
        }
    }
}
