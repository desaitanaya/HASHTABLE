using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTableProgram
    { 
        int size;
        private Node[] StringArray;

        public HashTableProgram(int size)
        {
            this.size = size;
            StringArray = new Node[size];
        }

        public void Add(string data)
        {
            Node newNode = new Node(data);

            int arrayIndex = Math.Abs(data.GetHashCode()) % StringArray.Length; //3213465432 10

            newNode.next = StringArray[arrayIndex];
            StringArray[arrayIndex] = newNode;

        }


        public void Search(string data)
        {
            int arrayIndex = Math.Abs(data.GetHashCode()) % StringArray.Length;

            Node temp = StringArray[arrayIndex];

            while (temp != null)
            {
                if (temp.Data.Equals(data))
                {
                    Console.WriteLine("Present at " + arrayIndex);
                    break;

                }
                else
                {
                    Console.WriteLine("Not Present");
                    break;

                }

                temp = temp.next;
            }

        }


        public void Remove(string data)
        {
            int arrayIndex = Math.Abs(data.GetHashCode()) % StringArray.Length;
            Node temp = StringArray[arrayIndex];
            Node previous = null;

            while (temp != null)
            {
                if (temp.Data.Equals(data))
                {
                    if (previous == null)
                    {
                        // The node to be removed is the first node in the bucket
                        StringArray[arrayIndex] = temp.next;
                    }
                    else
                    {
                        previous.next = temp.next;
                    }
                    return;
                }

                previous = temp;
                temp = temp.next;
            }
        }


        public void Display()
        {
            for (int index = 0; index < StringArray.Length; index++)
            {
                Node temp = StringArray[index];
                Console.Write($"\n Index - {index} ");
                while (temp != null)
                {
                    Console.Write($"{temp.Data} -> ");
                    temp = temp.next;
                }
                Console.Write("END");
                Console.WriteLine();
            }
        }
    }
}
   