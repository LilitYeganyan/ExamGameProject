namespace ExamGameProject
{
    internal class GameManager : IGameManager
    {

        public List<IStep> TicketsList { get; }
        public List<IUser> UsersList { get; }
        ILogger logger { get; set; } = new Logger();

        IStep tick1 = new Step(0);
        IStep tick2 = new Step(0);
        IStep tick3 = new Step(0);
        IStep tick4 = new Step(0);
        IStep tick5 = new Step(0);
        IStep tick6 = new Step(0);
        public GameManager()
        {
            this.TicketsList = new List<IStep>() { tick1, tick2, tick3, tick4, tick5, tick6 };
            this.UsersList = new List<IUser>();
            GiveTicketsValue(this.TicketsList);
        }

        private void GiveTicketsValue(List<IStep> list)
        {
            Random random = new Random();
            int r = random.Next(0, 500);
            for (int i = 0; i < list.Count; i++)
            {
                this.TicketsList[i].Ticket = r;
            }
        }

        public void WinnerTickets(IStep ticket)
        {
            if (ticket.Ticket == 0)
            {
                Console.WriteLine("There is no profit !");
                return;
            }
            else
            {
                Console.WriteLine("You Won!");
                Console.WriteLine("Press 1 for open other thicet (^_^)");
            }
        }

        public void AddUsers(IUser user)
        {
            this.UsersList.Add(user);
            this.logger.Info("The user was registered");
        }

        public List<IStep> GiveTiketsList()
        {
            List<IStep> list = new List<IStep>();
            list = this.TicketsList;
            return list;
        }
    }
}
