namespace BerlinClock.Classes
{
    class RedLamp : IBerlinClockLamp
    {
        public string TurnOn()
        {
            return "R";
        }

        public string TurnOff()
        {
            return "O";
        }
    }
}
