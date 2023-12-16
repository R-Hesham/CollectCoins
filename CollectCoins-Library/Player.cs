using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectCoins_Library
{
    internal class Player
    {
        string name = string.Empty;
        Point2D position = new Point2D();
        char symbol;

        public Player(string name, char symbol)
        {
            Symbol = symbol;
            Name = name;
        }

        public Point2D Position { get => position; set => position = value; }
        public string Name { get => name; set => name = value; }
        public char Symbol { get => symbol; set => symbol = value; }

        public void MoveUp()
        {
            position.Y--;
        }
        public void MoveDown()
        {
            position.Y++;
        }
        public void MoveRight()
        {
            position.X++;
        }
        public void MoveLeft()
        {
            position.X--;
        }
    }
}
