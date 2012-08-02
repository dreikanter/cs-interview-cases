using System;
using System.Globalization;

namespace InterviewCases.Cases
{
    // Q: Write Fizz-Buzz on paper (15 minutes)

    // Requirements - Part 1
    // * Iterate through numbers 1 – 100
    // * For numbers evenly divisible by 3 write “Fizz”
    // * For numbers evenly divisible by 5 write “Buzz”
    // * For numbers evenly divisible by 3 and 5 write “FizzBuzz”

    // Requirements - Part 2
    // Parameterize the method
    // * Allow the caller to specify the count to iterate to, in the above example 100
    // * Allow the caller to specify the value for Fizz, in the above example 3
    // * Allow the caller to specify the value for Buzz, in the above example 5
 
    public class FizzBuzzCase : Case
    {
        public void FizzBuzz()
        {
            for (var i = 1; i <= 100; i++)
            {
                var fizz = i % 3 == 0;
                var buzz = i % 5 == 0;

                if (fizz) Console.Write("Fizz");
                if (buzz) Console.Write("Buzz");
                if (fizz || buzz) Console.WriteLine();

                // Printing non-fizz/buzz numbers is not required but
                // according to classic Fizz Buzz rules it should be:

                // Console.WriteLine((fizz || buzz) ? String.Empty : i.ToString(CultureInfo.InvariantCulture));
            }
        }

        public void FizzBuzz(int count, int fizz, int buzz)
        {
            if (count < 0) throw new ArgumentOutOfRangeException("count");
            if (fizz == 0) throw new ArgumentOutOfRangeException("fizz");
            if (buzz == 0) throw new ArgumentOutOfRangeException("buzz");

            for (var i = 1; i <= count; i++)
            {
                var gotFizz = i % fizz == 0;
                var gotBuzz = i % buzz == 0;

                if (gotFizz) Console.Write("Fizz");
                if (gotBuzz) Console.Write("Buzz");
                if (gotFizz || gotBuzz) Console.WriteLine();

                //Console.WriteLine((gotFizz || gotBuzz) ? String.Empty : i.ToString(CultureInfo.InvariantCulture));
            }
        }

        protected override void Main()
        {
            FizzBuzz(100, 3, 5);
        }

        // Comments: Jeff Atwood on FizzBuzz "problem": Why Can't Programmers.. Program?
        // http://www.codinghorror.com/blog/2007/02/why-cant-programmers-program.html
    }
}
