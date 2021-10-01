using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class uc1simplelinkedlist
    {
        public static void simplelinllist()
        {
            // Create the link list.
            string[] words =
                { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            
        }
    }
}