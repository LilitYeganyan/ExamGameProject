namespace ExamGameProject
{
    internal class GameCreater
    {

        IGameManager GameManager { get; set; }
        public GameCreater()
        {
            this.GameManager = new GameManager();
        }

        public void GameStart()
        {
            while (true)
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("Press 1 for start");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.NumPad1:
                        Register();
                        break;
                }
            }
        }

        public void Register()
        {
            Console.Clear();
            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();

            IUser user = new User(pass);
            GameManager.AddUsers(user);
            PalyGame();

        }

        public void PalyGame()
        {
            List<IStep> list = GameManager.GiveTiketsList();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("***Try Your Luck***");
                Console.WriteLine("Maybe this is your lucky Tiket ");
                Console.WriteLine("Press 1 for Open");
                ConsoleKey key = Console.ReadKey().Key;

                for (int i = 0; i < list.Count; i++)
                {
                    if (key == ConsoleKey.NumPad1)
                    {
                        Console.WriteLine();
                        Console.WriteLine(list[i].Ticket);
                        {
                            GameManager.WinnerTickets(list[i]);
                            if (list[i].Ticket == 0)
                            {
                                Console.WriteLine("Gave Over !");
                                return;
                            }
                        }

                        continue;
                    }
                }

            }
        }

    }
}
