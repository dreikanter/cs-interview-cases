using System;

namespace InterviewCases.Cases
{
    public class ExceptionsCase1
    {
        public ExceptionsCase1()
        {
            try
            {
                Foo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Foo()
        {
            try
            {
                throw new Exception("A");
            }
            finally
            {
                throw new Exception("B");
            }
        }
    }
}