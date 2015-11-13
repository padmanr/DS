using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class BinaryNode<T> : Node<T> where T : IComparable
    {
        public BinaryNode<T> Left, Right;
    }
}
