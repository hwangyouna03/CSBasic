﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            } else if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다.");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다.");
            }
            double score = 3.7;
            if (score == 4.5)
            {
                Console.WriteLine("신");
            } else if (4.2 <= score)
            {
                Console.WriteLine("교수님의 사랑");
            }
            else if (3.5 <= score)
            {
                Console.WriteLine("협업");
            }
            else if (2.8 <= score)
            {
                Console.WriteLine("일반인");
            }
            else if (2.3 <= score)
            {
                Console.WriteLine("오락문화의 선구자");
            }
            else if (1.0 <= score)
            {
                Console.WriteLine("불가촉천민");
            }
            else if (0.5 <= score)
            {
                Console.WriteLine("자벌레");

            }
            else if (0 <= score)
                Console.WriteLine("플랑크톤");
             else
                    Console.WriteLine("시대를 앞서나가는 혁명의 씨앗");
         }
    }
}