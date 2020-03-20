using System;

namespace BoilerEvents
{
    public class RecordBoilerInfo
    {

        static void Logger(string info)
        {
            Console.WriteLine(info);
        }

        static void Main(string[] args)
        {
            BoilerInfoLogger filelog = new BoilerInfoLogger("boiler.txt");
            DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();

            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(Logger);
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(filelog.Logger);

            boilerEvent.LogProcess();
            
            Console.ReadLine();

            filelog.Close();
        }

    }
}
