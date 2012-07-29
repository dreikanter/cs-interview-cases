using System;

namespace InterviewCases.Cases
{
    public class TryCase1 : Case
    {
        protected override void Main()
        {
            try
            {
                Environment.Exit(0);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}