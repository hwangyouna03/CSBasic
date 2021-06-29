using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic51
{
    class Program
    {
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
        }
    }
}
