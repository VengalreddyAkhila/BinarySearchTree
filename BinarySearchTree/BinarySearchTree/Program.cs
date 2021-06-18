using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BinarySearch Tree");
            BinaryTree<int> binaryTree = new BinaryTree<int>(56);
            binaryTree.Add(30);
            binaryTree.Add(70);
            Console.WriteLine("Binary Search Tree is:-");
            binaryTree.Display();           
        }
    }
}
