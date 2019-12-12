namespace BerlinClock.Classes
{
    public class OneMinuteRow : BerlinClockRow
    {
        public OneMinuteRow(bool isLast = false) : base(isLast, CreateLamps()) { }

        private static IBerlinClockLamp[] CreateLamps()
        {
            return new IBerlinClockLamp[]
            {
                new YellowLamp(),
                new YellowLamp(),
                new YellowLamp(),
                new YellowLamp()
            };
        }

        public override string GetState(RegularTime time)
        {
            var lampsOn = time.Minutes % 5;
            return CalculateLamps(lampsOn);
        }
    }
}