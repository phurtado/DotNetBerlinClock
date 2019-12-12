using System;

namespace BerlinClock.Classes
{
    class TimeParser
    {
        public RegularTime Parse(string aTime)
        {
            var splitTime = aTime.Split(':');
            if (splitTime.Length != 3)
            {
                throw new FormatException("Invalid time format. Must be HH:mm:ss.");
            }
            var hours = int.Parse(splitTime[0]);
            var minutes = int.Parse(splitTime[1]);
            var seconds = int.Parse(splitTime[2]);
            return new RegularTime(hours, minutes, seconds);
        }
    }
}
