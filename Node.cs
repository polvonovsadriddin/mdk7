using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_mdk_7
{
    public class Node<T>
    { public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node <T>Next { get; set; }
    }
}
