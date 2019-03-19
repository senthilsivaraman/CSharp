using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLearning
{
    class ElseIf
    {
        ElseIf()
        {
            Console.WriteLine("Control Statement ElseIf block");
        }

        public static void elseIfMethod()
        {
            int a = 100, b = 97, c = 120, d = -200;

            if (a > b && a > c && a > d)
            {
                Console.WriteLine("A {0} is greater", a);
            }

            else if (b > a && b > c && b > d)
            {
                Console.WriteLine("B {0} is greater", b);
            }

            else if (c > a && c > b && c > d)
            {
                Console.WriteLine("C {0} is greater", c);
            }

            else
            {
                Console.WriteLine("D {0} is greater", d);
            }
        }
    }

}
