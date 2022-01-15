using System;
using System.IO;

namespace SOLID.Services
{
    public class Logger
    {
        public static void Log(string logMessage)
        {
            using (var sr = new StreamWriter("log.txt"))
            {
                sr.WriteLine(logMessage);
            }
        }
    }
}
