using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLearning
{
    class VarDataType
    {
        VarDataType()
        {
            Console.WriteLine("Var Data Type Block");
        }

        public static void varDataBlock()
        {
            //Using var data type and finding the data type

            var varTypeA = 3;
            var varTypeB = 'a';
            var varTypeC = " This is varString";

            Console.WriteLine("Finding the data type");
            Console.WriteLine("- - - - - - - - - - - ");
            Console.WriteLine("Data type of varTypeA is {0}", varTypeA.GetType().ToString());
            Console.WriteLine("Data type of varTypeB is {0}", varTypeB.GetType().ToString());
            Console.WriteLine("Data type of varTypeC is {0}", varTypeC.GetType().ToString());
            Console.WriteLine();

            //Printing var data
            Console.WriteLine("Printing var data");
            Console.WriteLine("- - - - - - - - - - - ");
            Console.WriteLine("varTypeA" + " " + varTypeA);
            Console.WriteLine("varTypeB" + " " + varTypeB);
            Console.WriteLine("varTypeC" + " " + varTypeC);
            Console.WriteLine();
        }
    }
}
