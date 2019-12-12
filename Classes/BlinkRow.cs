using System;

namespace BerlinClock.Classes
{
    public class BlinkRow : BerlinClockRow
    {
        public BlinkRow(bool isLast = false) : base(isLast, CreateLamps()) { }

        private static IBerlinClockLamp[] CreateLamps()
        {
            return new IBerlinClockLamp[]
            {
                new YellowLamp()
            };
        }

        public override string GetState(RegularTime time)
        {
            var lampsOn = time.Seconds % 2 == 0 ? 1 : 0;
            return CalculateLamps(lampsOn);
        }
    }
}