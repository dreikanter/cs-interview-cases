using System;

namespace InterviewCases.Cases
{
    public class ExceptionsCase3 : Case
    {
        protected override void Main()
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