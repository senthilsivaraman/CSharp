using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLearning
{
    class Program
    {
        public static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Available Functions in this Program \n");
            do
            {
                Console.WriteLine(" \n \n 1. Var Data Type \n 2. Type conversion \n 3. Dynamic Data Type \n 4. Else if Control \n 5. Exit");
                Console.WriteLine("\n Enter your option");
                option = Convert.ToInt32(Console.ReadLine());

                if (option > 0 && option < 6)
                {
                    switch (option)
                    {
                        case 1:
                            VarDataType.varDataBlock();
                            break;
                        case 2:
                            TypeConversion.typeConversionBlock();
                            break;
                        case 3:
                            DynamicDataType.dynamicDataBlock();
                            break;
                        case 4:
                            ElseIf.elseIfMethod();
                            break;
                        case 5:
                            Console.WriteLine("See you");
                            System.Threading.Thread.Sleep(2000);
                            Environment.Exit(0);
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Exiting..Sorry Try Again Later...");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);

                }

            } while (option >= 1 && option <= 4);



            Console.ReadKey();

        }
    }

}
