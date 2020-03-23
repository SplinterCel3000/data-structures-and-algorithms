using System;
using Xunit;
using LinkedList;
using LinkedList.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void NodeClassHasValueProperty()
        {
            // Arrange Act
            // looking for the class named Node. 
            // instantiate an object from the Node Class. 
            Node node = new Node();

            // Assert
            Assert.IsType<int>(node.Value);
        }
        /// <summary>
        /// This is grabbing the current value of the node
        /// </summary>
        [Fact]
        public void CanGetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;

            Assert.Equal(10, node.Value);
        }
        /// <summary>
        /// This is testing to make sure we can set and or change the property of the node
        /// </summary>
        [Fact]
        public void CanChangeAndSetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;
            node.Value = 15;

            Assert.Equal(15, node.Value);
        }

        [Fact]
        public void NodeClassHasNextProperty()
        {
            Node node = new Node();
            Assert.Null(node.Next);
        }
        /// <Tsummary>
        /// This checks to see if the next property of the node can be set. So if 18 is already there can we set the next one.
        /// </summary>
        [Fact]
        public void NextProperyOnNodeCanBeSet()
        {
            Node node = new Node();
            node.Value = 18;

            Node node2 = new Node();
            node.Next = node2;

            Assert.Equal(node.Next, node2);
        }
        /// <summary>
        /// Checks for a head
        /// </summary>
        [Fact]
        public void LinkedListClassHasHeadProperty()
        {
            Linklist linkList = new Linklist();
            Assert.Null(linkList.Head);
        }
        /// <summary>
        /// You can insert to the head. 
        /// </summary>
        [Fact]
        public void CanInsertNewNodeToLinkedListAsHead()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            Assert.Equal(10, ll.Head.Value);

        }
        /// <summary>
        /// This checks to make sure that you can re set the head if its set already
        /// </summary>
        [Fact]
        public void CanInsertNewNodeAsHeadInLLThatAlreadyHasNodes()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);

            Assert.Equal(20, ll.Head.Value);
        }
        /// <summary>
        /// This makes sure you can find a value in the list
        /// </summary>
        [Fact]
        public void CanFindNodeWithValueInLL()
        {
            // Arrange
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(30);

            // Assert
            // method call will be true
            Assert.True(exists);
        }
        /// <summary>
        /// Checks to see if something is there if it isnt it doesnt return it.
        /// </summary>
        [Fact]
        public void CannotFindNodewithValueinLL()
        {
            // Arrange
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(32);

            Assert.False(exists);
        }
        /// <summary>
        /// This one checks for the last file in the link list. 
        /// </summary>
        [Fact]
        public void CanFindHeadValueSuccessfullyInLL()
        {
            // Arrange
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(42);
            Assert.True(exists);

        }
        /// <summary>
        /// this checks for the first value
        /// </summary>
        [Fact]
        public void CanFindLastNodeValueInLL()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(10);
            Assert.True(exists);
        }
        /// <summary>
        /// This will print out the list to a string 
        /// </summary>
        [Fact]
        public void CanConvertLinkListToString()
        {
            // Arrange
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act 
            string allyson = ll.ToString();

            string expected = $"42 -> 30 -> 20 -> 10 -> NULL"; 
            // Assert
            Assert.Equal(expected, allyson);

        }
    }
}
