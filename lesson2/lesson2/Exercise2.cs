using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Exercise2
    {
        int n;

        public Exercise2() { n = 0; } 

        public Exercise2(int m) { n = m; }

        public string Interval()
        {
            if (n >= 0 && n <= 14)
            {
                return "[0 - 14]";
            }
            else if (n >= 15 && n <= 35)
            {
                return "[15 - 35]";
            }
            else if (n >= 36 && n <= 50)
            {
                return "[36 - 50]";
            }
            else if (n >= 51 & n <= 100)
            {
                return "[51 - 100]";
            }
            else
            {
                Console.WriteLine("Error: the number is not included in any of the numeric gaps!");
                return null;
            }
        }
    }
}
