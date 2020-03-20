using System.IO;

namespace BoilerEvents
{
    public class BoilerInfoLogger
    {
        FileStream fs;
        StreamWriter writer;

        public BoilerInfoLogger(string filename)
        {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            writer = new StreamWriter(fs);
            writer.AutoFlush = true;
        }

        public void Logger(string info)
        {
            writer.WriteLine(info);
        }

        public void Close()
        {
            writer.Close();
            fs.Close();
        }

    }
}
