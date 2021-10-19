using System;

namespace CrackingTheCodeLabWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    class Node<T>
    {
        //data
        public T Value { get; set; } //stores the value
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        //methods

        //ctors
        public Node(T val)
        {
            Value = val;
        }
    }
}
