using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Algorithm6
{
    /// Класс для объявления и инициализации вершин графа и ребра в виде списка смежности
    public class Graph
    {
        /// Описание графа в виде списка смежности.
        /// Имея все вершины вместе со всеми ребрами на каждом из них.           
        public Dictionary<int, HashSet<int>> AdjacencyList = new Dictionary<int, HashSet<int>>();

        public Graph(int[] Vertices, Tuple<int, int>[] edges)
        {
            foreach (int vertex in Vertices)
            {
                AddVertex(vertex);
            }

            foreach (Tuple<int, int> edge in edges)
            {
                AddEdge(edge);
            }
        }

        /// Метод добавления вершины в граф, если таковой не существует.           
        public void AddVertex(int vertex)
        {
            // Проверка на существование такой вершины в гарфе.
            if (!AdjacencyList.ContainsKey(vertex))
            {
                AdjacencyList.Add(vertex, new HashSet<int>());
            }
        }

        /// Метод добавления ребра между заданными вершинами.
        public void AddEdge(Tuple<int, int> edge)
        {
            // Проверка, существуют ли обе вершины в графе, если да, то добавляется ребро к двум вершинам.
            if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
            {
                AdjacencyList[edge.Item1].Add(edge.Item2);
                AdjacencyList[edge.Item2].Add(edge.Item1);
            }
        }
    }
}
