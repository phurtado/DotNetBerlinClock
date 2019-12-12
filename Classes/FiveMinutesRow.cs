using System;

namespace BerlinClock.Classes
{
    public class FiveMinutesRow : BerlinClockRow
    {
        public FiveMinutesRow(bool isLast = false) : base(isLast, CreateLamps()) { }

        private static IBerlinClockLamp[] CreateLamps()
        {
            return new IBerlinClockLamp[]
            {
                new YellowLamp(),
                new YellowLamp(),
                new RedLamp(),
                new YellowLamp(),
                new YellowLamp(),
                new RedLamp(),
                new YellowLamp(),
                new YellowLamp(),
                new RedLamp(),
                new YellowLamp(),
                new YellowLamp()
            };
        }

        public override string GetState(RegularTime time)
        {
            var lampsOn = time.Minutes / 5;
            return CalculateLamps(lampsOn);
        }
    }
}