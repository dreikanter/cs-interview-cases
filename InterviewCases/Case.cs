using System;

namespace InterviewCases
{
    public abstract class Case
    {
        protected Case()
        {
            Go();
        }

        public void Go()
        {
            try
            {
                Main();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}; {1}", ex.GetType().Name, ex.Message);
            }
        }

        protected abstract void Main();
    }
}
