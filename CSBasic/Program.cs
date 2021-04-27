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
            //var name = "황윤아";
            //var something = "blahblah"; var는 맴버변수 위치에 사용 X

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

            var somea = "마음에 드는 문자열";
            var someb = 42;
            var somec = 3.141592;
            Console.WriteLine(somea.GetType());
            Console.WriteLine(someb.GetType());
            Console.WriteLine(somec.GetType());


            bool isLoop = true;
            string input;
            while (isLoop)
            {
                Console.Write("입력>>");
                input = Console.ReadLine();
                if(input.Equals("q"))
                    break;
                else
                    Console.WriteLine(input);
                
            }
            var a1 = (int)10.0;
            var b1 = (float)10;
            var c1 = (double)10;

            long longNumber = 214783637L + 2500000000L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            long longNumber2 = 52773;
            int intNumber2 = (int)longNumber2;
            Console.WriteLine(intNumber2);

            Console.WriteLine("int, long, float, double 맥스밸류");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine("문자열의 숫자로의 형변환");
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.32"));
            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());

            //잘못된 형변환
            try
            {
                Console.WriteLine(int.Parse("52.273"));
                Console.WriteLine(int.Parse("abc"));
                Console.WriteLine(int.Parse("육심삽"));
                Console.WriteLine(int.Parse("Seven"));
            }catch(FormatException e)
            {
                Console.WriteLine("숫자를 입력하세요: "+e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("알수 없는 에러: " + e.Message);
            }

            //ToString()
            (10).ToString();
            (52.283).ToString();

            double numberToString = 52.273103;
            Console.WriteLine(numberToString.ToString("0.0")); //52.3 출력됨
            Console.WriteLine(numberToString.ToString("0.00"));
            Console.WriteLine(numberToString.ToString("0.000"));
            Console.WriteLine(numberToString.ToString("0.0000"));

            //숫자와 문자열 덧셈
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");
            Console.WriteLine(52 + 2 + 273);
            Console.WriteLine(52 + "2" + 273);
            Console.WriteLine("52" + 2 + 273);
            Console.WriteLine(52 + 2 + "273");

            int number = 52273;
            string ouputA = number + "";

            char character = 'a';
            string outputB = character + "";
            Console.WriteLine(outputB);

            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("TRUE"));
            Console.WriteLine(bool.Parse("truE"));
            Console.WriteLine(bool.Parse("TrUe"));

            int outputInt = int.MinValue;
            Console.WriteLine(-(long)outputInt);
            Console.WriteLine(-(-214783647));
            
        }
    }
}
