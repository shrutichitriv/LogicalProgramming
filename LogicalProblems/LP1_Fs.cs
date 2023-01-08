using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class LP1_Fs
    {
        public static void Fibonacci_Series()
        {
            //Variable
            int a = 0, b = 1, c, i;

            Console.WriteLine("How many N numbers you want:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (i = 2; i < n; i++)//For Loop
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
