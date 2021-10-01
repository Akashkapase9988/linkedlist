using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
   public class uc2linkedlist
    {
        
         public   static void linkedlist()
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
            }
        }
    }

