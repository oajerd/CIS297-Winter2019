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

            string result = String.Empty;

            if ( age > favoriteNumberNumerically )
            {
                result = "You are old!";
            }
            else
            {
                result = "Get a better number!";
            }
            // ternary or conditional operator - page 67
            result = age > favoriteNumberNumerically ? "You are old!" : "Get a better number!";

            Console.WriteLine(result);

            age += 50.5;

            // don't do this
            string[] names, ages;

            names = new string[3];

            // use the .Length property on arrays when iterating
            for ( int index = 0; index < names.Length; index++ )
            {
                Console.WriteLine("Enter a name: ");
                names[index] = Console.ReadLine();
            }

            ages = new string[] { "10", "20", "30" };

            foreach ( var name in names )
            {
                Console.WriteLine(name);
            }

            var maxAge = int.MinValue;

            foreach ( var someAge in ages )
            {
                if ( Convert.ToInt32(someAge) > maxAge )
                {
                    maxAge = Convert.ToInt32(someAge);
                }
            }




            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
