using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class SingleNode<T> : Node<T> where T : IComparable
    {
        public SingleNode<T> Next { get; set; }
    }
}
