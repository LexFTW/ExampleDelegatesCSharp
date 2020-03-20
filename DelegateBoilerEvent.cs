namespace BoilerEvents
{
    public class DelegateBoilerEvent
    {
        public delegate void BoilerLogHandler(string status);

        public event BoilerLogHandler BoilerEventLog;

        public void LogProcess()
        {
            string remarks = "OK";
            
            Boiler boiler = new Boiler(100, 20);

            int temp = boiler.Temp;
            int pressure = boiler.Pressure;

            if (temp > 150 || temp < 80 || pressure < 12 || pressure > 15)
                remarks = "Need Maintenance";

            OnBoilerEventLog("Logging Info:\n");
            OnBoilerEventLog("Temperature: " + temp + "\nPressure: " + pressure);
            OnBoilerEventLog("\nMessage: " + remarks);
        }

        protected void OnBoilerEventLog(string message)
        {
            if (BoilerEventLog != null)
                BoilerEventLog(message);
        }
    }
}
