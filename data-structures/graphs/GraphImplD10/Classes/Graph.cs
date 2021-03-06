﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GraphImplD10.Classes
{
    public class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        private int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        // Add Node/Vertex to the graph/adjacency List
        public Vertex<T> AddNode(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            _size++;
            return node;
        }

        // add edge
        public Edge<T> AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            Edge<T> edge = new Edge<T>


            {
                Vertex = b,
                Weight = weight

            };
            AdjacencyList[a].Add(edge);
            return edge;

        }
        /// <summary>
        /// Adds undirected edge
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="weight"></param>
        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }
        /// <summary>
        /// This lists all the vertices
        /// </summary>
        /// <returns></returns>
        public List<Vertex<T>> GettAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();

            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);
            }

            if (vertices.Count == 0)
                return null;
            else
            return vertices;
        }

        // Get Neighbors
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            // get all edges connected to a vertex
            return AdjacencyList[vertex];
        }

        public int Size()
        {
            return _size;
        }
        /// <summary>
        /// This will print out all the edges and the vertexs for our graph. 
        /// </summary>
        public void Print()
        {
            foreach (var vertex in AdjacencyList)
            {
                Console.Write($"{vertex.Key.Value}: ");

                foreach (var edge in vertex.Value)
                {
                    Console.Write($"{edge.Vertex.Value}, {edge.Weight} ->");
                }
                Console.WriteLine("null");
            }
        }

    }
}
