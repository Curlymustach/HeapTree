using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapTree
{
    class Node<T> where T : IComparable<T>
    {
        public T Value;
        public Node<T> Parent;
        public Node<T> Right;
        public Node<T> Left;
        public int Index;

        public Node(T Value)
        {
            this.Value = Value;
        }
    }
}
