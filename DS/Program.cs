using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            // List(args);
            Graph();
            Console.ReadKey();
        }

        static void Graph()
        {
            BST<int> tree = new BST<int>();
            tree.InOrder();
            tree.Insert(87);
            tree.InOrder();

            tree.Insert(new int[] { 234, 632, 123, 654, 1, 354, 0 });
            tree.InOrder();
            tree.PreOrder();
            tree.PostOrder();

            tree.LevelOrder();
        }

        static void List(string[] args)
        {
            SingleList<int> SList = new SingleList<int>();

            SList.Print();

            SList.Push(45);
            SList.Print();
            SList.Reverse();
            SList.Print();
            SList.Push(54);
            SList.Print();
            SList.Reverse();
            SList.Print();
            int[] intArray = { 234, 632, 123, 654, 1, 354, 0 };
            SList.Push(intArray);
            SList.Print();
            SList.Reverse();
            SList.Print();
        }
    }
}
