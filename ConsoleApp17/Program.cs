using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    using System;

    class Program
    {
        static bool IsPowerOfTwo(int n)
        {
            
            if (n == 1)
                return true;

            if (n < 1)
                return false;
            
            if (n % 2 != 0)
                return false; 

            return IsPowerOfTwo(n / 2); 
        }
        static void Main()
        {
            
        }
    }
}
