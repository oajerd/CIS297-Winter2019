using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_NetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello class!");

            Console.WriteLine("Please enter your favorite number");


            // user input fun
            var favoriteNumber = Console.ReadLine();
            var favoriteNumberNumerically = Convert.ToDouble(favoriteNumber);

            // string interpolation - use the $ and {}
            Console.WriteLine("Your favorite number " +
                $"squared is: {favoriteNumberNumerically * favoriteNumberNumerically}");

            string eric = "Eric";

            // prefer lower case string
            //String Eric = "Eric";

            // read page 39
            int thirteen = 0b00001101;

            // you've gone too far with the digit separator
            int bigNumber = 123_4_5_6_789;

            var age = 31.0;

            // please don't do this
            int a, b, c, d, e, f;
            a = b = c = d = e = f = 10;

            for (int outerLoopIndex = 0; outerLoopIndex < 10; outerLoopIndex++)
            {
                for (int innerLoopIndex = 0; innerLoopIndex < 10; innerLoopIndex++)
                {
                    //Console.WriteLine(outerLoopIndex * innerLoopIndex);
                }
            }

            age += 50.5;

            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
