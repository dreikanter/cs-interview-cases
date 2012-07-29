using System;
using System.Linq;

namespace InterviewCases.Cases
{
    public class GcCase1 : Case
    {
        protected override void Main()
        {
            var array = new[] {new A("1"), new A("2")};
            Print(array);
            Clear(array);
            Print(array);
        }

        private static void Clear(A[] array)
        {
            array = null;
        }

        private static void Print(A[] array)
        {
            var values = from item in array select item.ToString();
            Console.WriteLine(String.Join(", ", values.ToArray()));
        }
        
        public class A
        {
            private readonly string a;

            public A(string value)
            {
                a = value;
            }

            public override string ToString()
            {
                return a;
            }
        }
    }
}