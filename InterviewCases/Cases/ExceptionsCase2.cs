using System;

namespace InterviewCases.Cases
{
    public class ExceptionsCase2
    {
        public ExceptionsCase2()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}