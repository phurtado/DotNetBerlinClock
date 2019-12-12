using System;

namespace BerlinClock.Classes
{
    public class RegularTime
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public RegularTime(int hours, int minutes, int seconds)
        {
            if (hours < 0 
                || hours > 24 
                || minutes < 0 
                || minutes > 59 
                || seconds < 0 
                || seconds > 59 
                || (hours == 24 && (minutes > 0 || seconds > 0))
                )
            {
                throw new FormatException($"Invalid time: {hours}:{minutes}:{seconds}");
            }

            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}