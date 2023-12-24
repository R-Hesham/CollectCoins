using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectCoins_Library
{
    public class Game1Player : IGame
    {
        Player player;
        Board board;

        public Board Board { get => board; set => board = value; }
        public Player Player { get => player; set => player = value; }

        public Game1Player()
        {
            board = new Board();
        }
        public void StartGame()
        {
            Console.WriteLine("Game with 1 player started");
            Console.WriteLine(Player);
            Console.WriteLine(Board);
        }

        public void MovePlayer(string direction)
        {
            switch(direction)
            {
                case "up":
                    Point2D point = Player.Position;
                    Player.MoveUp();
                    char oldChar;
                    int result = Board.ReplaceOnBoard(Player.Symbol, point, Player.Position, out oldChar);
                    switch (result)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }
                    break;
                case "down":
                    Player.MoveDown();
                    break;
                case "left":
                    Player.MoveLeft();
                    break;
                case "right":
                    Player.MoveRight();
                    break;
            }
        }


        public void GameInstructions()
        {

        }
    }
}
