using TupleTe = (float, char); 
using TupleTe = (bool, int, double); //duplicate top-level alias
using MyArr = int[,,]; //duplucate alias
namespace ProjectReference
{
    using TestT = (string, int);
    using TestT = (char, bool); //duplicate alias inside namespace
    using MyArr = double[,,]; //duplicate alias
    public class Point
    {
        private MyArr a = new double[,,]{};
        private TupleTe t = (true, 4, 5.0);
        private TestT t = ("", 5);
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
