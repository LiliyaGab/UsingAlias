using TupleTest = (bool, char); // Quick fixes - set language version
using Tuple2 = int[];
using unsafe Arr = int*[]; // TODO: add possible constructions
using unsafe UnsafeInt = int*;
using ArrMulti = double[,,];
using ArrJagged = char[][]; 
using NVT = int?;
using NRTInside = System.Collections.Generic.List<string?>;
using Dyn = dynamic;
using unsafe Deleg = delegate*<delegate* managed<string, int>, delegate*<string, int>>;
using unsafe VoidTest = void*; 
using unsafe UnsafeInt = int*; 
using unsafe PPint = int**;
using TupleNamed = (bool flag, double num, string str);
using D = dynamic[];

namespace NotSetLangVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
