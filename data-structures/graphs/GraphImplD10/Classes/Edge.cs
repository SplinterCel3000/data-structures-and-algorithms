using System;
using System.Collections.Generic;
using System.Text;

namespace GraphImplD10.Classes
{/// <summary>
/// set up for edge class
/// </summary>
/// <typeparam name="T"></typeparam>
    public class Edge<T>
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }
    }
}
