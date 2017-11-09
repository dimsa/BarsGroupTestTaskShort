using System.IO;

namespace ProductPackagerApp.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            var path = Directory.GetCurrentDirectory();
            using (StreamWriter outputFile = new StreamWriter(path + @"\AppLog.txt", true))
            {
                outputFile.WriteLine(message);
            }            
        }
    }
}
