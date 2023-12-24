namespace CollectCoins_Library
{
    public class Board
    {
        char[,] matrix;
        public Board()
        {
            matrix = new char[,]
            {
                {' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                {' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                {' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                {' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                {' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                {' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                {' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                {' ',' ',' ',' ',' ',' ',' ',' ',' ' },
                {' ',' ',' ',' ',' ',' ',' ',' ',' ' },
            };
        }

        public char[,] Matrix { get => matrix; set => matrix = value; }

        /// <summary>
        /// This function is for the first assignment on the board
        /// </summary>
        /// <param name="ch">the player or coin symbol</param>
        /// <param name="x">the new position in x axis</param>
        /// <param name="y">the new position in y axis</param>
        /// <returns>
        /// true: if the symbol is placed successfully.
        /// false: if the symbol Can't be placed on this point
        /// </returns>
        public bool PlaceOnBoard(char ch, int x, int y)
        {
            if (matrix[x, y] != ' ')
            {
                return false;
            }
            matrix[x, y] = ch;
            return true;
        }
        public bool PlaceOnBoard(char ch, Point2D point)
        {
            if (matrix[point.X, point.Y] != ' ')
            {
                return false;
            }
            matrix[point.X, point.Y] = ch;
            return true;
        }
        /// <summary>
        /// this function for moving from point to another
        /// </summary>
        /// <param name="ch">the player or coin symbol</param>
        /// <param name="xOld">the old position in x axis</param>
        /// <param name="yOld">the old position in y axis</param>
        /// <param name="xNew">the new position in x axis</param>
        /// <param name="yNew">the new position in y axis</param>
        /// <returns>
        /// 1: to indecate replacing symbol successfuly
        /// 2: to indecate replacing symbol with removing another symbole
        /// 3: to indecate invalid old position for this symbol
        /// </returns>
        public int ReplaceOnBoard(char ch, int xOld, int yOld, int xNew, int yNew, out char previousSymbol)
        {
            if (matrix[xOld, yOld] == ch)
            {
                matrix[xOld, yOld] = ' ';
                if (matrix[xNew, yNew] != ' ')
                {
                    previousSymbol = matrix[xNew, yNew];
                    matrix[xNew, yNew] = ch;
                    return 2;
                }
                else
                {
                    previousSymbol = ' ';
                    matrix[xNew, yNew] = ch;
                    return 1;
                }
            }
            else
            {
                previousSymbol = matrix[xNew, yNew];
                return 3;
            }
        }
        public int ReplaceOnBoard(char ch, Point2D oldPoint, Point2D newPoint, out char previousSymbol)
        {
            if (matrix[oldPoint.X, oldPoint.Y] == ch)
            {
                matrix[oldPoint.X, oldPoint.Y] = ' ';
                if (matrix[newPoint.X, newPoint.Y] != ' ')
                {
                    previousSymbol = matrix[newPoint.X, newPoint.Y];
                    matrix[newPoint.X, newPoint.Y] = ch;
                    return 2;
                }
                else
                {
                    previousSymbol = ' ';
                    matrix[newPoint.X, newPoint.Y] = ch;
                    return 1;
                }
            }
            else
            {
                previousSymbol = matrix[oldPoint.X, oldPoint.Y];
                return 3;
            }
        }
        public override string ToString()
        {
            string board = "#==1==2==3==4==5==6==7==8==9=*\n";
            for (int i = 1; i < 10; i++)
            {
                board += $"{i}=";
                for (int j = 1; j < 10; j++)
                {
                    board += "   ";
                }
                board += "*\n";
            }
            return board;
        }
    }
}
