namespace BerlinClock.Classes
{
    class YellowLamp : IBerlinClockLamp
    {
        public string TurnOn()
        {
            return "Y";
        }

        public string TurnOff()
        {
            return "O";
        }
    }
}
