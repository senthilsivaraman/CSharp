using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLearnings
{
    class StringOperations
    {
        StringOperations()
        {
            Console.WriteLine("String Operations Block");
            Console.WriteLine("- - - - - - - - - - - - - -");
        }
        public static void stringOperations()
        {
            char[] stringArray = { 's', 'e', 'n', 't', 'h', 'i', 'l' };
            string myName = new string(stringArray);
            Console.WriteLine("My name is {0}", myName);
        }

    }
}
