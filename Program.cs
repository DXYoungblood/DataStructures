using System;

namespace ConsoleApp1
{
    
       class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
        }
    }
    
    
    class node <T>
    {
        int value;
        public node <T> next;

        public node <T> (int Value)
        {
            value = Value;
            next = null;
        }

        public int getValue()
        {
            return value;
        }
    }

 

    class linkedlist<T>
    {
        node<T> head;

        public linkedlist()
        {
            head = null;
        }

        public bool isEmpty()
        {
            return head == null;
        }

        public void addFirst(int x)
        {
            node finger = new node(x);

            if (isEmpty())
            {
                head = finger;
            }
            else
            {
                finger.next = head;
                head = finger;
            }
        }
       
        public void deleteFirst()
        {
            if (!isEmpty())
            {
                head = head.next;
            }
        }

        public void print()
        {
            node finger = head;

            string s = "";
            while (finger != null)
            {
                s += finger.getValue() + " ";
                finger = finger.next;
            }

            Console.WriteLine(s);
        }

        public void removeDups()
        {
         

        }
    }
}
