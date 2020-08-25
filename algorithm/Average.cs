using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    class Average
    {
        static void Main()
        {
            //[?] n명의 점수 중에서 80점 이상 95점 이하인 점수의 평균

            //[1] Input :
            int[] data = {90, 65, 78, 50, 95 };
            int sum = 0;
            int count = 0;


            //[2] Process : avarage = sum / count
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 80 && data[i] <= 95)
                {
                    sum += data[i];
                    count++;
                }
            }

            double avg = sum / (double)count;


            //[3] Output
            Console.WriteLine($"{data.Count()}명의 점수 중에서 80점 이상 95점 이하인 점수의 평균 : {avg}");

            //[4] 식(Linq)
            Console.WriteLine(data.Where(d => d >= 80 && d <= 95).Average());
        }

    }
}
