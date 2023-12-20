using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectCoins_Library
{
    public class Game1Player
    {
        Player player;
        Board board;

        public void MovePlayer(string direction)
        {
            switch(direction)
            {
                case "up":
                    Point2D point = player.Position;
                    player.MoveUp();
                    char oldChar;
                    int result = board.ReplaceOnBoard(player.Symbol, point, player.Position, out oldChar);
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
                    player.MoveDown();
                    break;
                case "left":
                    player.MoveLeft();
                    break;
                case "right":
                    player.MoveRight();
                    break;
            }
        }
    }
}
