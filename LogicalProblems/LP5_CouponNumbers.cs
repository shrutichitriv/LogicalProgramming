using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class LP5_CouponNumbers
    {
        public static void Generatingnumbers()
        {
            Console.WriteLine("How many times do you need to generate a Coupon Code");
            int Coupon = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Coupon; i++)
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTabcdefghijklmnopqrst1234567890";
                var stringchars = new char[6];
                var random = new Random();

                for (int j = 0; j < stringchars.Length; j++)
                {
                    stringchars[j] = chars[random.Next(stringchars.Length)];
                }

                var coupon = new string(stringchars);
                Console.WriteLine("Generating Coupon number {0} is {1}", i, coupon);
            }

        }
    }
}
