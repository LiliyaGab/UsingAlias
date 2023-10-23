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
        private int x; 
        private int y; 
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

        public int Y
        {
            get => y;
            set => y = value;
        }
    }
}
