using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class uc3append
    {
       

            public static void appendlinkedlist()
            {
                LinkedList<int> L = new LinkedList<int>();

                L.AddLast(56);
                L.AddLast(30);
                L.AddLast(70);
                Console.Write("Linked List elements are: ");
                foreach (int i in L)
                {
                    Console.Write(i + " ");
                }
            }
        }
    
}
