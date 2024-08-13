using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__LINQ_Task1
{
    internal static class IntExtension
    {
        public static int Reverse(this int number) // 12345
        {
            int reversedNumber = 0, lastDigit;

            while (number > 0)
            {
                lastDigit = number % 10; // 1
                reversedNumber = reversedNumber * 10 + lastDigit; //  54321
                number = number / 10; // 0

            }
            return reversedNumber;

        }

        // 12345 % 10 = 5
        // 12345/ 10 = 1234

        // 1234 % 10 = 4
        // 1234/ 10 = 123

        // 123 % 10 = 3
        // 123/ 10 = 12

        // 12 % 10 = 2
        // 12/ 10 = 1

        // 1 % 10 = 1
        // 1/ 10 = 0


        public static long Reverse(this long number) // 12345
        {
            long reversedNumber = 0, reminder;

            while (number != 0)
            {
                reminder = number % 10; // 1
                reversedNumber = reversedNumber * 10 + reminder; //  54321
                number = number / 10; // 0

            }
            return reversedNumber;

        }
    }
}
