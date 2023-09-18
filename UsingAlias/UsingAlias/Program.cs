using unsafe VoidTest = void*;
using unsafe UnsafeInt = int*;
using unsafe PPint = int**;
using unsafe ArrOfPointers = int*[];
using TupleNamed = (bool flag, double num, string str);
using TupleIntString = (int, string);
using unsafe sp = System.Span<int>*;

namespace UsingAlias
{
    using TupleIntString = (int, string);
    using ArrInt = int[];
    using TupleRef = Tuple<int, int>;
    using ArrMulti = double[,,];
    using ArrJagged = char[][];
    using NVT = int?;
    //using NRT = string?; 
    using NRTInside = List<string?>;
    using Dyn = dynamic;
    using unsafe sp = Span<int>*;
    using UserType = TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw;
    using unsafe TypeUnsafe = TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw*;
    using unsafe D = delegate* unmanaged[Stdcall, SuppressGCTransition]<int, int>;
    using unsafe Del = delegate* unmanaged<string, delegate*<int>>;
    using unsafe Deleg = delegate*<delegate* managed<string, int>, delegate*<string, int>>;


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public delegate void FooBarDelegate(String x);

    public class TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw
    {
        private TupleIntString t = (10, "sfsff");
    }
}
