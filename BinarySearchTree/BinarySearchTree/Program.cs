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
            binaryTree.Add(12);
            binaryTree.Add(66);            
            Console.WriteLine("Binary Search Tree is:-");
            binaryTree.Display();
            int[] arr = { 12,30,56,66,70 };
            int n = arr.Length;
            int x = 70;
            int result = binaryTree.BinarySearch(arr, 0, n - 1, x);
            if (result == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element found at index "
                                  + result);
        }
    }
    
}
