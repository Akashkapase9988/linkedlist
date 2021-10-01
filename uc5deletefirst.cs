using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class uc5deletefirst
    {
        public static void deletefirst()
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


            L.RemoveFirst();
            Console.ReadKey();
            Console.Write("After removing first elemet Linked List elements are: ");
            foreach (int i in L)
            {
                Console.Write(i + " ");
            }
        }
    }
}
    

