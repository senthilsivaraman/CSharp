using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLearning
{
    class TypeConversion
    {
        TypeConversion()
        {
            Console.WriteLine("Type Conversion Block");
        }

        public static void typeConversionBlock()
        {
            Console.WriteLine("Type Conversion - Implicit");
            Console.WriteLine("- - - - - - - - - - - - - - - - ");
            int i = 345;
            float f = i;
            Console.WriteLine(f);
            Console.WriteLine();

            Console.WriteLine("Type Conversion - Explicit");
            Console.WriteLine("- - - - - - - - - - - - - - - - ");
            int i1 = 345;
            float f1 = 34.65f;
            Console.WriteLine(i1.ToString());
            Console.WriteLine(f1.ToString());
        }
    }
}
