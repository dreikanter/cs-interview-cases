using System;

namespace InterviewCases.Cases
{
    public class TryCase2 : Case
    {
        protected override void Main()
        {
            goto TRY;

            RETURN: return;

            TRY:
            try
            {
                goto RETURN;
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}