using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class SingleList<T> where T : IComparable
    {
        SingleNode<T> head;

        public void Push(T node)
        {
            if (node == null)
            {
                return;
            }

            if (this.head == null)
            {
                head = new SingleNode<T> { Data = node };
                return;
            }

            SingleNode<T> current = head;
            while(current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new SingleNode<T> { Data = node }; ;
        }

        public void Push(T[] values)
        {
            if (values == null)
            {
                return;
            }

            if (this.head == null)
            {
                this.head = new SingleNode<T> { Data = values[0] };
                SingleNode<T> current = head;

                for (int i = 1; i < values.Length; i++)
                {
                    current.Next = new SingleNode<T> { Data = values[i] };
                    current = current.Next;
                }
            }
            else
            {
                SingleNode<T> current = head, prev = head;
                while (current != null)
                {
                    prev = current;
                    current = current.Next;
                }

                foreach (T value in values)
                {
                    prev.Next = new SingleNode<T> { Data = value };
                    prev = prev.Next;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("***List is***");

            if (this.head == null)
            {
                return;
            }

            SingleNode<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + "\t");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public void Reverse()
        {
            Console.WriteLine("### Reversed ###");
            if (this.head == null || this.head.Next == null)
            {
                return;
            }

            SingleNode<T> prev = null, current = this.head, next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            this.head = prev;
        }
    }
}
