using System;

namespace BerlinClock.Classes
{
    public abstract class BerlinClockRow
    {
        public bool IsLast;
        private readonly IBerlinClockLamp[] BerlinClockLamps;

        public abstract string GetState(RegularTime time);

        public BerlinClockRow(bool isLast, IBerlinClockLamp[] berlinClockLamps)
        {
            IsLast = isLast;
            BerlinClockLamps = berlinClockLamps;
        }

        private string AddNewlineIfLast()
        {
            if (!IsLast)
            {
                return Environment.NewLine;
            }
            return "";
        }

        protected string CalculateLamps(int lampsOn)
        {
            var result = "";
            for (var i = 0; i < lampsOn; i++)
            {
                result += BerlinClockLamps[i].TurnOn();
            }
            for (var i = lampsOn; i < BerlinClockLamps.Length; i++)
            {
                result += BerlinClockLamps[i].TurnOff();
            }
            return result + AddNewlineIfLast();
        }
    }
}