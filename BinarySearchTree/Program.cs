using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {// Testing both methods
            BinarySearch search = new BinarySearch();

            search.AddNode(new Node(50));
            search.AddNode(new Node(75));
            search.AddNode(new Node(47));
            search.AddNode(new Node(100));
            search.AddNode(new Node(35));
            search.AddNode(new Node(24));

            
            bool valueFound = search.SearchTree(35);

            Console.WriteLine(valueFound);
            Console.ReadLine();


            // Binary Search Tree
            /*  50  
                / \
              47   75
             / \   / \
            35       100
           / \       / \
          24              */
        }
    }
}
