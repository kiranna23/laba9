using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Exercise4
    {
        int number;

        public Exercise4(int number) { this.number = number; }

        public Exercise4() { number = 0; }

        public bool SearchOnDiv()
        {
            return (number % 2 == 0);
        }

        public bool SearchOnLetter()
        {
            string number1 = Convert.ToString(number);
            char symbol = number1[number1.Length - 1];
            if (symbol == '0' || symbol == '2'|| symbol == '4' || symbol == '6' || symbol == '8')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
