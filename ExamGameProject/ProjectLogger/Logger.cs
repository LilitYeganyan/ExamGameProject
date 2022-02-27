using System.Text;

namespace ExamGameProject
{
    internal class Logger : ILogger
    {
        public void Log(string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            using (FileStream file = new FileStream("Logger.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                file.Write(bytes, 0, bytes.Length);
            }
        }

        public void Info(string message)
        {
            string error = $"Error: {message}";
            Log(error);
        }

        public void Erroe(string message)
        {
            string info = $"Info: {message}";
            Log(info);
        }
    }
}
