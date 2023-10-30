using System.Globalization;
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
// TODO: use aliases in different contexts.
#if NET7_0
		tuple.Item1 = "Hello";
#else
		tuple.Item1 = 5;
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