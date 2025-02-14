using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    using System;

    class Program
    {
        static void Main()
        {
            int result = Power(2, 3);
            Console.WriteLine(result);  
        }

        static int Power(int a, int b)
        {

            if (b == 0)
            {
                return 1;
            }
            else
            {

                return a * Power(a, b - 1);
            }
        }
    }
}

