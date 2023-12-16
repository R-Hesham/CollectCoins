namespace CollectCoins_Library
{
    public class Point2D
    {
        int x, y;

        public int X
        {
            get => x;
            set
            {
                if(value >= 0) { x = value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
        }

        public int Y
        {
            get => y;
            set
            {
                if (value >= 0) { y = value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
        }

        public Point2D()
        {
            x = 0;
            y = 0;
        }
        public Point2D(int x,int y)
        {
            Y = y;
            X = x;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}
