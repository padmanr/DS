﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class Node<T> where T : IComparable
    {
        public T Data { get; set; }
    }
}
