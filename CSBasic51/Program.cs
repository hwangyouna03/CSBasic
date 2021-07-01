﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic51
{
    class Program
    {
        public int instanceVariable = 10;
        public int instanceMethod()
        {
            return 0;
        }
        class MyMath
        {
            public static int Abs(int input)//첫글자 대문자 Abs
            {
                return (input < 0) ? -input : input;
                /*
                if(input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }*/
            }
        }
        class Test
        {
            //Method Signature : 메소드 구분할 때 쓴다.
            public int Sum(int min, int max)
            {
                int output = 0;
                for(int i = min; i <=max; i++)
                {
                    output += i;
                }
                return output;
            }
        }
        class MethodExample
        {
            public int Power(int x)
            {
                return x * x;
            }
            public int Multi(int x, int y)
            {
                return x * y;
            }
            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출됨");
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetIntime();
            car.setOutTime();

            Random random = new Random();
            random.Next();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(20, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));


            Console.WriteLine(random.NextDouble()* 10);
            Console.WriteLine(random.NextDouble()* 10);

            Console.WriteLine(random.Next(20));
            Console.WriteLine(random.Next(20)+1);
            Console.WriteLine(random.Next(1,21));

            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArray = new string[10];

            List<int> list = new List<int>();


            MethodExample me = new MethodExample();
            Console.WriteLine(me.Power(10));
            Console.WriteLine(me.Power(20));
            Console.WriteLine(me.Multi(52, 273));
            Console.WriteLine(me.Multi(103, 32));

            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100)); //1부터 100까지 합
            
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            //클래스 메서드에서는 인스턴스 변수/메서드 접근 불가
            //객체를 만들어 접근해야한다.
            //Console.WriteLine(instanceVariable);
            //instanceMethod();
            Program p = new Program();
            Console.WriteLine(p.instanceVariable);
            p.instanceMethod();


        }
    }
}