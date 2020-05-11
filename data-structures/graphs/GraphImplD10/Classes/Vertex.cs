using System;
using System.Collections.Generic;
using System.Text;

namespace GraphImplD10.Classes
{
    // This was class 08!!!!
    /// <summary>
    /// This is our set up for vertexes
    /// </summary>
    /// <typeparam name="Potato"></typeparam>
    class Vertex<Potato>
    {
        public Potato Value { get; set; }

        public Vertex(Potato value)
        {
            Value = value;
        }
    }
}
