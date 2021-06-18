using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    /// <summary>
    /// creating a Binary Search Tree 
    /// </summary>
    /// <typeparam name="T"></typeparam>

    class BinaryTree<T> where T : IComparable
    {
        T INode;       
        public BinaryTree<T> leftnode{ get; set; }
        public BinaryTree<T> rightnode{ get; set; }      

        public BinaryTree(T INode)
        {            
            this.INode = INode;           
            this.leftnode = null;
            this.rightnode = null;
        }
        /// <summary>
        /// Adding the items in BST By Lefttree and Right tree
        /// </summary>
        /// <param name="item"></param>
        public void Add(T data)
        {
            T node = this.INode;
            if ((node.CompareTo(data)) > 0)
            {
                if (this.leftnode == null)
                    this.leftnode = new BinaryTree<T>(data);
                else
                    this.leftnode.Add(data);
            }
            else
            {
                if (this.rightnode == null)
                    this.rightnode = new BinaryTree<T>(data);
                else
                    this.rightnode.Add(data);
            }
            
        }
        /// <summary>
        /// display the BST list
        /// </summary>
        public void Display()
        {
            if (this.leftnode != null)            
                this.leftnode.Display();
            Console.WriteLine(this.INode);
             if (this.rightnode != null)            
                this.rightnode.Display();           
        }
    }
}
