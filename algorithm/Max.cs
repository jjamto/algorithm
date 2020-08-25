using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    /// <summary>
    ///  최대값 알고리즘 : (주어진 범위 + 주어진 조건)의 자료들의 가장 큰 값
    /// </summary>
    class Max
    {
        static void Main()
        {


            //[?] 

            //[0]Initialize
            int max = int.MinValue; //정수 형식의 데이터 중 가장 작은 값으로 초기화

            //[1] Input : 
            int[] numbers = { -2, -5, -3, -7, -1 };

            //[2] Process :
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i]; // max : 더 큰 값으로 할당
                }
            }

            //[3] Output
            Console.WriteLine($"최댓값 : {max}");

            //[4] 식(Linq)
            Console.WriteLine($"식의 값 : {numbers.Max()}");
        }


    }
}
