using TupleTe = (float, char); 
//using TupleTe = (bool, int, double); //duplicate top-level alias
using MyArr = int[,,]; //duplicate alias
namespace ProjectReference
{
    using TestT = (string, int);
    //using TestT = (char, bool); //duplicate alias inside namespace
    using MyArr = double[,,]; //duplicate alias
    public class Point // TODO: reference in alias in referencing project
    {
        private MyArr a = new double[,,]{};
        //private TupleTe t = (true, 4, 5.0);
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

namespace ProjectReference2
{
    using Class2 = (string, int); // TODO: Same name as type

	internal class Class2
	{
		private MyArr Tm = new int[1,2,3]; // TODO: reference top level alias

		//public void Test(Class2 parameter)
		//{
		//}
	}
}
