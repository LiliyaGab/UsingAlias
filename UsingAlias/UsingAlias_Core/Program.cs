using unsafe VoidTest = void*;
using unsafe UnsafeInt = int*;
using unsafe PPint = int**;
using unsafe ArrOfPointers = int*[];
using TupleNamed = (bool flag, double num, string str);
using TupleIntString = (int, string);
using unsafe sp = System.Span<int>*;
using D = dynamic[];


namespace UsingAlias
{
    using TupleIntString = (int, string); //use this type alias where possible
    using TupleIS = (int, string);
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
    using unsafe EnumT = MyEnum;
    using static unsafe TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw;
    using static Instance;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //InstanceMethod();
            TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw t =
                new TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw();

        }
    }
    public delegate void FooBarDelegate(String x);

    public class TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw
    {
        private TupleIntString t = (10, "sfsff");

        public static void Method() {}
    }

    public class CheckUseThisTypeAlias
    {
        private (int, string) tuple;

        public void Method()
        {
            tuple = (3, "6");
        }
    }
    unsafe class Util
    {
        public static void Log() { }

        void Use()
        {
            delegate*<void> ptr1 = &Util.Log; //introduce type alias
        }
    }
    unsafe class Instance
    {
        void Use()
        {
            static string toString(Instance i) => i.ToString();
            delegate*<Instance, string> f = &toString;
            f(this);
        }

        public static void InstanceMethod() { }
    }

    enum MyEnum
    {
        value1, value2, value3, value4, value5, value6
    }
}
