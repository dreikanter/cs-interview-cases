using System;

namespace InterviewCases.Cases
{
    // Q: What time is it? (15 minutes)

    // Requirements
    // * Given the position of the hour hand in degrees; what time is it?

    // A:

    public class WhatTimeIsItCase : Case
    {
        public const double HourStep = 360 / 12;

        public const double MinuteStep = HourStep / 60;

        public const double SecondStep = MinuteStep / 60;

        private static double NormalizeAngle(double angle)
        {
            var normAngle = angle % 360;
            return (normAngle < 0) ? (angle + 360) % 360 : normAngle;
        }

        private static int GetModulo(double angle, double divider)
        {
            // Range checking is not important because the function is private
            // if (divider < 0) throw new ArgumentOutOfRangeException("divider");

            var result = NormalizeAngle(angle) / divider;
            if (result < 0) result += 360 / divider;
            return Convert.ToInt32(Math.Floor(result));
        }

        public TimeSpan GetTime(double angle)
        {
            var hour = GetModulo(angle, HourStep);
            var minute = GetModulo(angle, MinuteStep) % 60;
            var second = GetModulo(angle, SecondStep) % 60;

            return new TimeSpan(0, hour, minute, second);
        }

        protected override void Main()
        {
            const double thirtySec = 1.5 * MinuteStep;

            for (var angle = 0.0; angle < 360.0; angle += thirtySec)
            {
                Console.WriteLine(GetTime(angle));
            }
        }
    }

    // Q: What kinds of information can you tell about the time?
    // A: Hours in 12h format, minutes, seconds.

    // Q: What kinds of information can’t you tell about the time?
    // A: Is it AM or PM. Timzone is unknown too.

    // Q: What assumptions are you making?
    // A: 1) hour hand moves evenly, continuously and precise enough
    // to determine minutes and seconds value. 2) 12h format w/o AM/PM
    // specification is Ok.
}
