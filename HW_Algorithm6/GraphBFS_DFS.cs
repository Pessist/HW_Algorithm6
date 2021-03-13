using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Algorithm6
{
    public static class GraphBFS_DFS
    {

        public static HashSet<int> DepthFirstSearch(Graph graph, int start)
        {
            //хранить вершины в том порядке, в котором они были посещены.
            HashSet<int> visited = new HashSet<int>();

            // проверка, если ли такая вершина
            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            Console.WriteLine("Depth First Search:");

            var Stack = new Stack<int>();
            //добавляем элемент на начальную вершину в стеке.
            Stack.Push(start);

            while (Stack.Count > 0)
            {
                // Извлекаем последнюю вершину из стека.
                int vertex = Stack.Pop();

                if (!visited.Contains(vertex))
                {
                    visited.Add(vertex);
                    Console.Write(vertex + " ");

                    foreach (int adjacent in graph.AdjacencyList[vertex])
                    {
                        if (!visited.Contains(adjacent))
                        {
                            Stack.Push(adjacent);
                        }
                    }
                }
            }
            Console.WriteLine("\n");

            return visited;
        }


        public static HashSet<int> BreadthFirstSearch(Graph graph, int start)
        {
            //хранить вершины в том порядке, в котором они были посещены.
            HashSet<int> visited = new HashSet<int>();

            // проверка, если ли такая вершина
            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            Console.WriteLine("Breadth First Search:");

            var Queue = new Queue<int>();
            //добавляем элемент на начальную вершину в очереди.
            Queue.Enqueue(start);

            while (Queue.Count > 0)
            {
                int vertex = Queue.Dequeue();

                if (!visited.Contains(vertex))
                {
                    visited.Add(vertex);
                    Console.Write(vertex + " ");

                    foreach (int adjacent in graph.AdjacencyList[vertex])
                    {
                        if (!visited.Contains(adjacent))
                        {
                            Queue.Enqueue(adjacent);
                        }
                    }
                }

            }
            Console.WriteLine();
            return visited;
        }
    }
}
