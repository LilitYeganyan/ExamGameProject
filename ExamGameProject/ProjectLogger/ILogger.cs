namespace ExamGameProject
{
    internal interface ILogger
    {
        void Log(string message);
        void Erroe(string message);
        void Info(string message);
    }
}
