using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
      //var keyword는 지역변수로만 사용 가능
        static void Main(string[] args)
        {
            //keyword
            //int as;

            //context keyword
            var name = "황윤아";

            //식별자 Identifier
            int alpha;
            int Alpha;
            //int 😒😊❤; 
            //int has space;

            /// xml 주석 
            //inline comment

            /* comment*/

            //출력
            Console.WriteLine("Hello");
            Console.Write("이건 안개행");
            Console.Write("입니다.\n");

            //자료형(Data type)
            //Integer
            Console.WriteLine(53 + 272);
            Console.WriteLine(53 * 3 - 3);
            Console.WriteLine(14 / 2);
            Console.WriteLine(14 / 3);
            Console.WriteLine(14 % 3);

            //Real Number
            Console.WriteLine(0.0);
            Console.WriteLine(13.123);
            Console.WriteLine(14.0 / 3.0);
            Console.WriteLine(14.0 / 2.0);
            Console.WriteLine(14 / 3);
            Console.WriteLine(14 / 3);//4
            Console.WriteLine(14.0 / 3); //4.66666667
            Console.WriteLine(14 / 3.0);//4.666667
            Console.WriteLine(14.0 / 3.0);//4.66666

            //Character
            Console.WriteLine('A'); //문자
            //String
            Console.WriteLine("A"); //문자열
           //Escape Character
           Console.WriteLine("\t 탭 \\ 역슬래시 \n 개행 \"");
           Console.WriteLine("미\t림여자정보과학고등학교");
           Console.WriteLine("미림\t여자정보과학고등학교");
           Console.WriteLine("미림여\t자정보과학고등학교");
            Console.WriteLine("미림여자정\t보과학고등학교");
            Console.WriteLine("미림여자정보\t과학고등학교");
            Console.WriteLine("미림여자정보과\t학고등학교");
            Console.WriteLine("미림여자정보과학\t고등학교");
            Console.WriteLine("미림여자정보과학고\t등학교");
            Console.WriteLine("미림여자정보과학고등\t학교");
            Console.WriteLine("미림여자정보과학고등학\t교");
            Console.WriteLine("미림여자정보과학고등학교\t");
        }
    }
}
