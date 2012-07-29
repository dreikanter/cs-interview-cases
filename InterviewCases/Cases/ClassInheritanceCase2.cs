using System;

namespace InterviewCases.Cases
{
    public class ClassInheritanceCase2 : Case
    {
        protected override void Main()
        {
            var x = 10;
            new Derived().Foo(x);
        }

        public class Base
        {
            public virtual void Foo(int x)
            {
                Console.WriteLine("In Base.foo");
            }
        }

        public class Derived : Base
        {
            public override void Foo(int x)
            {
                Console.WriteLine("In Derived.Foo(int x)");
            }

            public void Foo(object o)
            {
                Console.WriteLine("In Foo(object o)");
            }
        }
    }
}