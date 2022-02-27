namespace ExamGameProject
{
    internal class User : IUser
    {
        public string Password { get; }
        public User() { }
        public User(string pass)
        {
            this.Password = pass;
        }
    }
}
