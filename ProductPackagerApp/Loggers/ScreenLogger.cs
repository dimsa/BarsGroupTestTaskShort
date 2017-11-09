using ProductPackagerApp.Common;
using System;

namespace ProductPackagerApp.Loggers
{
    public class ScreenLogger : ILogger
    {
        private InformDelegate Inform;

        public void Log(string message)
        {
            Inform(message, ConsoleColor.DarkGray);
        }

        public ScreenLogger(InformDelegate informDelegate)
        {
            Inform = informDelegate;
        }
    }
}
