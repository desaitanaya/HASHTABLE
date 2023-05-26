using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{

    public class Node
    {
        public string Data { get; }
        public Node next { get; set; }

        public Node(string data)
        {
            Data=data;
            next = null;
        }
    }
}
