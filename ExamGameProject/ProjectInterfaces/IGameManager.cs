namespace ExamGameProject
{
    internal interface IGameManager
    {
        List<IStep> TicketsList { get; }
        void AddUsers(IUser user);
        List<IStep> GiveTiketsList();
        void WinnerTickets(IStep ticket);
    }
}
