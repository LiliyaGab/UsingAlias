using unsafe Alias = delegate*<void>;
#if NET7_0
using T = (string, int, bool);
#elif NET48
//using unsafe Alias = delegate* unmanaged<string, delegate*<int>>;
using D = int[];
using T = (int, double, char);
#endif
namespace Multitarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            T tuple = new T();
        }
        public unsafe class Util
        {
            public static void Log() { }

            void Use()
            {
                Alias ptr1 = &Util.Log; //introduce type alias
            }
        }
    }
}
