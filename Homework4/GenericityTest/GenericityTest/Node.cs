using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericityTest
{
    class Node <T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }

        public static void Each(GenericList<T> nodes , Action<T> f)
        {
            Node<T> node = nodes.Head;
            while (node != null)
            {
                f(node.Data);
                node = node.Next;
            }
        }
    }

    class GenericList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
    }
}
