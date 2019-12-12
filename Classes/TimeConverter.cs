using BerlinClock.Classes;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        private readonly TimeParser TimeParser = new TimeParser();

        public string convertTime(string aTime)
        {
            var berlinClockRows = new BerlinClockRow[]
            {
                new BlinkRow(),
                new FiveHoursRow(),
                new OneHourRow(),
                new FiveMinutesRow(),
                new OneMinuteRow(isLast: true)
            };

            var parsedTime = TimeParser.Parse(aTime);
            var convertedTime = "";
            foreach (var row in berlinClockRows)
            {
                convertedTime += row.GetState(parsedTime);
            }

            return convertedTime;
        }
    }
}
