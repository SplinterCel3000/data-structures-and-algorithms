
using System;
using Xunit;
using GraphImplD10.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
            Graph<string> test1 = new Graph<string>();
            var thing = test1.AddNode("yes");

            Assert.Contains(thing, test1.GettAllVertices());

        }

        [Fact]
        public void CanAddEdge()
        {
            Graph<string> test2 = new Graph<string>();
            var a = test2.AddNode("yes");
            var b = test2.AddNode("thing");
            var c = test2.AddDirectedEdge(a, b, 40);
            Assert.Contains(c, test2.AdjacencyList[a]);
        }

        [Fact]
        public void CanGetAllNodes()
        {
            Graph<string> test3 = new Graph<string>();
            test3.AddNode("yes");
            test3.AddNode("no");
            test3.AddNode("thing");
            Assert.Equal(3, test3.GettAllVertices().Count);
        }

        [Fact]
        public void CanGetNeighbors()
        {
            Graph<string> test4 = new Graph<string>();
            var a = test4.AddNode("yes");
            var b = test4.AddNode("no");
            var c = test4.AddNode("thing");
            var d = test4.AddDirectedEdge(a, b, 40);
            var e = test4.AddDirectedEdge(a, c, 40);
            Assert.True(test4.GetNeighbors(a).Contains(d) && test4.GetNeighbors(a).Contains(e));
        }

        [Fact]
        public void CanGetNeighborWeight()
        {
            Graph<string> test5 = new Graph<string>();
            var a = test5.AddNode("yes");
            var b = test5.AddNode("no");
            var d = test5.AddDirectedEdge(a, b, 40);
            Assert.Equal(60, test5.GetNeighbors(a)[0].Weight);
        }

        [Fact]
        public void CanGetSize()
        {
            Graph<string> test6 = new Graph<string>();
            test6.AddNode("yes");
            test6.AddNode("no");
            test6.AddNode("maybe");
            Assert.Equal(3, test6.Size());
        }

        [Fact]
        public void CanGetSingleNode()
        {
            Graph<string> test7 = new Graph<string>();
            var a = test7.AddNode("yes");

            Assert.Equal(1, test7.Size());
        }

        [Fact]
        public void ReturnsNullForEmpty()
        {
            Graph<string> test8 = new Graph<string>();

            Assert.Null(test8.GettAllVertices());
        }
    }
}
