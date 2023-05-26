using System;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size : ");
            size = int.Parse(Console.ReadLine());

            HashTableProgram hashTableProgram = new HashTableProgram(size);

            hashTableProgram.Add("Hello");
            hashTableProgram.Add("World");
            hashTableProgram.Add("New");
            hashTableProgram.Add("Friend");
            hashTableProgram.Display();

            hashTableProgram.Search("New");

            hashTableProgram.Remove("World");
            hashTableProgram.Display();

        }
    } 
}
