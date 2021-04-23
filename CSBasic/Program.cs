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

            //문자열 연결 연산자
            //concat concatenate operaotr
            //concatenation operator
            Console.WriteLine("ABC" + "EFG");
            Console.WriteLine('A' + 'E'); //->정수로 판단해서 134를 출력한다.
            Console.WriteLine("ABC" + 'E');
            Console.WriteLine("ABC"[2]);
            Console.WriteLine("ABC"[3]);//에러 발생 IndexOoutOfBounce

            //bool
            bool isPlay = true;
            bool isDeath = false;

            //comparison operator
            Console.WriteLine(52 == 163);
            Console.WriteLine(52 != 163);
            Console.WriteLine(52 > 163);//gt
            Console.WriteLine(52 < 163);//lt
            Console.WriteLine(52 >= 163);
            Console.WriteLine(52 <= 163);
            //Console.WriteLine(52 =! 163);
            //Console.WriteLine(52 => 163);
            //Console.WriteLine(52 =< 163);

            //Logic operator
            Console.WriteLine(!(true));
            Console.WriteLine(true || false);
            Console.WriteLine(true && false);

            //단항연산자 - unary operator
            Console.WriteLine(!(true));
            int i = 0;
            i++; //연산자에 대응하는 것이 하나여서 단항연산자
            //이항연산자 - binary operator
            i = i + 2;
            //삼항연산자 - ternary operator
            int j;
            //  [1] ? [2] : [3] -> 연산자가 3개
            j = (i > 3) ? 0 : 1;

            //Console.WriteLine(3 <i <8);
            Console.WriteLine(3 < i && i < 8);
            Console.WriteLine(3 > i || i > 8);
            Console.WriteLine(i < 3 || 8 < i);

            int a = 2147483640;
            int b = 100000000;
            Console.WriteLine((long)a + b);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(-int.MaxValue);
            //Console.WriteLine(-int.MinValue); 오류남

            Console.WriteLine(3L);
            Console.WriteLine(3L);

            Console.WriteLine(3);
            Console.WriteLine(3.0);

            char c = 'a';
            Console.WriteLine(c);

            //sizeof (자료형)
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));

            bool IsLive = true;

            //증감연산자
            //전위, 후위에 따라서 출력 값이 변할 수 있으니 주의
            int num = 10;
            Console.WriteLine(num++);
            Console.WriteLine(++num);
            Console.WriteLine(num--);
            Console.WriteLine(--num);

            //복합대입연산자
            int output = 0;
            output += 52;
            output = output + 52;
            output *= 10;
            output = output * 10;
            Console.WriteLine(output);

            //문자열 연결 연산자를 사용한 복합 연사낮
            string output3 = "hello";
            output3 += "World";
            output3 = output3 + "?";
            Console.WriteLine(output3);

            //자료형 검사
            int _int = 273;
            long _long = 52222731033265;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '귤';
            string _string = "문자열";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());

        }
    }
}
