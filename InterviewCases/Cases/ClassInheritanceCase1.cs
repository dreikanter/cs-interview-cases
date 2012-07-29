using System;

namespace InterviewCases.Cases
{
    public class ClassInheritanceCase1
    {
        public ClassInheritanceCase1()
        {
            var a = new A(1);
            Console.WriteLine("Main: {0}", a.Value);
            new P().Process(ref a);
            Console.WriteLine("Main: {0}", a.Value);
        }

        public class A
        {
            public int Value { get; set; }

            public A(int a)
            {
                Value = a;
            }
        }

        public class P
        {
            public void Process(ref A a)
            {
                Console.WriteLine("P: {0}", a.Value);
                a = new A(10);
                Console.WriteLine("P: {0}", a.Value);
            }
        }
    }
}