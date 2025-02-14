using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    using System;

    class Program
    {
        static void Main()
        {
            int num = 1234;
            Console.WriteLine(reverse(num));
        }

        static int reverse(int n)
        {

            if (n == 0)
            {
                return 0;
            }


            return (n % 10) * (int)Math.Pow(10, (int)Math.Log10(n)) + reverse(n / 10);
        }
    }
}

