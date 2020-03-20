namespace BoilerEvents
{
    public class Boiler
    {
        public int Temp { get; private set; }
        public int Pressure { get; private set; }

        public Boiler(int temp, int pressure)
        {
            Temp = temp;
            Pressure = pressure;
        }

    }
}
