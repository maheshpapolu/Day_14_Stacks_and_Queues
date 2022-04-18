using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    internal class Node<T>
    {
        public T data; // Adata variable
        public Node<T> next; // declaring a next node
        public Node(T data) // Crating constructor having node data as parameter
        {
            this.data = data;
        }
    }
}
