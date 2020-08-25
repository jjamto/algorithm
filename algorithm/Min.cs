using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    class Min
    {

        static void Main()
        {

            int min = int.MaxValue;

            int[] numbers = { -2, -5, -3, -7, -1 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"최소값 : {min}");
            Console.WriteLine($"식으로 최소값 : {numbers.Min()}");
        }

    }
}
