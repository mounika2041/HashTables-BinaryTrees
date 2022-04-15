using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables_BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to HashTables and BinaryTrees");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();
            Console.ReadLine();
        }
    }
}
       