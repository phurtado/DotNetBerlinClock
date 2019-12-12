using System;

namespace BerlinClock.Classes
{
    public class FiveHoursRow : BerlinClockRow
    {
        public FiveHoursRow(bool isLast = false) : base(isLast, CreateLamps()) { }

        private static IBerlinClockLamp[] CreateLamps()
        {
            return new IBerlinClockLamp[]
            {
                new RedLamp(),
                new RedLamp(),
                new RedLamp(),
                new RedLamp()
            };
        }

        public override string GetState(RegularTime time)
        {
            var lampsOn = time.Hours / 5;
            return CalculateLamps(lampsOn);
        }
    }
}