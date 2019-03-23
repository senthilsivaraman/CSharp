using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLearnings
{
    class DynamicDataType
    {
        public DynamicDataType()
        {
            Console.WriteLine("Dynamic Data Type");
        }

        public static void dynamicDataBlock()
        {
            Console.WriteLine("Dynamic Variable");
            Console.WriteLine("- - - - - - - - - - - - - - - - ");
            dynamic dynamicVariable = 120;
            Console.WriteLine(dynamicVariable.GetType().ToString());
            dynamic dynamicVariable2 = "This is my world";
            Console.WriteLine(dynamicVariable2.GetType().ToString());
        }
    }
}
