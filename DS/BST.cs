using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class BST<T> where T : IComparable
    {
        BinaryNode<T> root;

        public void Insert(T data)
        {
            if (this.root == null)
            {
                this.root = new BinaryNode<T> { Data = data };
                return;
            }

            BinaryNode<T> current = this.root;
            while(true)
            {
                if (current.Data.CompareTo(data) < 0)
                {
                    if (current.Right == null)
                    {
                        current.Right = new BinaryNode<T> { Data = data };
                        break;
                    }

                    current = current.Right;
                }
                else
                {
                    if (current.Left == null)
                    {
                        current.Left = new BinaryNode<T> { Data = data };
                        break;
                    }

                    current = current.Left;
                }
            }
        }

        public void Insert(IEnumerable<T> values)
        {
            foreach(T value in values)
            {
                this.Insert(value);
            }
        }

        public void InOrder()
        {
            Console.WriteLine("***InOrder***");
            this.InOrder(this.root);
            Console.WriteLine();
        }

        private void InOrder(BinaryNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            this.InOrder(node.Left);
            Console.Write(node.Data + "\t");
            this.InOrder(node.Right);
        }

        public void PreOrder()
        {
            Console.WriteLine("***PreOrder***");
            this.PreOrder(this.root);
            Console.WriteLine();
        }

        private void PreOrder(BinaryNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.Data + "\t");
            this.PreOrder(node.Left);
            this.PreOrder(node.Right);
        }

        public void PostOrder()
        {
            Console.WriteLine("***PostOrder***");
            this.PostOrder(this.root);
            Console.WriteLine();
        }

        private void PostOrder(BinaryNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            this.PostOrder(node.Left);
            this.PostOrder(node.Right);
            Console.Write(node.Data + "\t");
        }

        public void LevelOrder()
        {
            Console.WriteLine("***LevelOrder***");
            if (this.root == null)
            {
                return;
            }

            BinaryNode<T> node = this.root;
            Queue<BinaryNode<T>> queue = new Queue<BinaryNode<T>>();
            
            while (node != null)
            {
                Console.Write(node.Data + "\t");
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }

                node = queue.Count > 0 ? queue.Dequeue() : null;
            }

            Console.WriteLine();
        }
    }
}
