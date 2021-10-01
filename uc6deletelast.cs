using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class uc6deletelast
    {
        public static void deleteLirst()
        {
            LinkedList<int> L = new LinkedList<int>();

            L.AddFirst(70);
            L.AddFirst(30);
            L.AddFirst(56);
            Console.Write("Linked List elements are: ");
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }


            L.RemoveLast();
            Console.ReadKey();
            Console.Write("After removing first elemet Linked List elements are: ");
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }
        }
    }
}
