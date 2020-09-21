using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        public void LogError(string message)
        {
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine("ERROR: {0}", message);
            }
        }

        public void LogInfo(string message)
        {
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}
