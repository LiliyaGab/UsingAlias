namespace ProjectReference
{
    public class Point
    {
        private int x; // Do not rename (binary serialization)
        private int y; // Do not rename (binary serialization)
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            get => x;
            set => x = value;
        }

        /// <summary>
        /// Gets the y-coordinate of this <see cref='System.Drawing.Point'/>.
        /// </summary>
        public int Y
        {
            get => y;
            set => y = value;
        }
    }
}
