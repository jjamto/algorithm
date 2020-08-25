using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{

    class Sum
    {

        static void Main()
        {

            //[?] n명의 국어 점수 중에서 80점 이상인 점수의 합계


            //[1] Input : n명의 국어 점수

            int[] score = { 100, 75, 50, 37, 90, 95 };
            int sum = 0;


            //[2] Process : 합계 알고리즘 영역 - 주어진 범위에 주어진 조건(필터링)

            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] >= 80)
                {
                    sum += score[i];
                }

            }

            //[3] Output

            Console.WriteLine($"{score.Length}명의 점수 중 80점 이상의 총점: {sum}");

            //[4] 식
            Console.WriteLine((new int[] { 100, 75, 50, 37, 90, 95 }).Where(s => s >= 80).Sum()); 

        }
     }

    //[?] 

    //[1] Input : 

    //[2] Process :

    //[3] Output

    //[4] 식(Linq)

}