namespace CollectCoins_Library
{
    public class Game2Player : IGame
    {
        List<Player> m_players;
        Board board;

        public List<Player> Players { get => m_players; set => m_players = value; }
        public Board Board { get => board; set => board = value; }

        public Game2Player()
        {
            board = new Board();
        }
        public void StartGame()
        {
            Console.WriteLine("Game with 2 players started");
            foreach (var player in Players)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine(Board);
        }
    }
}
