using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double result1 = 0;
            bool chet = false;
            string word = "", sign = "", result2 = "";
            Exercise1 ex1 = new Exercise1();
            Console.Write("Enter the operation sign: ");
            sign = Console.ReadLine();
            result1 = ex1.Calculator(sign);
            if (result1 != 0)
            {
                Console.WriteLine("Result: " + result1);
            }
            Console.Write("Enter a number from 0 to 100: ");
            n = Convert.ToInt32(Console.ReadLine());
            Exercise2 ex2 = new Exercise2(n);
            result2 = ex2.Interval();
            if (result2 != null)
            {
                Console.WriteLine("The number is included in the numerical range: " + result2);
            }
            Exercise3 ex3 = new Exercise3();
            Console.Write("Enter the word in Russian: ");
            word = Console.ReadLine();
            result2 = ex3.Search(word);
            if (result2 != null)
            {
                Console.WriteLine("Word translation " + word + " into English: " + result2);
            }
            else
            {
                Console.WriteLine("The word is not in the dictionary.");
            }
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Exercise4 ex4 = new Exercise4(n);
            chet = ex4.SearchOnDiv();
            if (chet)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number isn't even");
            }
            Console.ReadKey();
        }
    }
}
