using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapTree
{
    class Tree<T> where T : IComparable<T>
    {
        T[] tree;
        Node<T> Head;
        int index = 0;

        public Tree(int size)
        {
            Head = null;
            tree = new T[size]; 
        }

        public void Insert(T value)
        {
            Head = Insert(Head, value);
        }

        public Node<T> Insert(Node<T> node, T value)
        {
            if(Head == null)
            {
                tree[0] = value;
                index++;
                return new Node<T>(value);
            }
            else if(index == tree.Length)
            {
                //T[] newTree = new T[tree.Length * 2];
                //for(int i = 0; i < newTree.Length; i++)
                //{
                //    newTree[i] = tree[i];
                //}
                //newTree[tree.Length] = value;
                Console.WriteLine("Heap Full.");
            }
            else
            {
                tree[index] = value;
                if(index % 2 != 0)
                {
                    node.Left = Insert(node.Left, value);
                }

            }


            


        }
    }
}
