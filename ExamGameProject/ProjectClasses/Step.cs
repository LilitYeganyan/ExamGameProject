namespace ExamGameProject
{
    internal class Step : IStep
    {
        public int Ticket { get; set; }

        public Step(int ticket)
        {
            this.Ticket = ticket;
        }
    }
}
