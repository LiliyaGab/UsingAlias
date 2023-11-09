using System.Globalization;
using SharedProject;
using SharedClass = (SharedProject.Class1, int);

#if NET7_0
using T = (string, int, bool);

#elif NET48
//using unsafe Alias = delegate* unmanaged<string, delegate*<int>>;
using D = int[];
using T = (int, double, char);
#endif
namespace Multitarget;

internal class Program
{
	private static void Main(string[] args)
	{
		var T = 1;
		Console.WriteLine(T);
		Console.WriteLine("Hello, World!");
		T tuple = new();
		T a = new(); // TODO: navigation.
		SharedClass clTuple = new SharedClass(new Class1(new ("", true)), 5);
// TODO: use aliases in different contexts.
#if NET7_0
		tuple.Item1 = "Hello";
        var f = Equals(clTuple.Item1.Tm.Item2, a.Item3);
#else
		tuple.Item1 = 5;
        var f = Equals(clTuple.Item1.Tm.Item1[1], a.Item3);
#endif
    }

	public unsafe class Util
	{
		public static void Log()
		{
		}

		private void Use()
		{
			delegate*<void> ptr1 = &Log; //introduce type alias // TODO: why is using placed inside namespace?
		}
	}
}