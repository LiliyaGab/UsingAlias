using System.Globalization;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Input;
using System.Drawing;
using unsafe VoidTest = void*;
using unsafe UnsafeInt = int*;
using unsafe PPint = int**;
using unsafe Arr = int*[];
using TupleNamed = (bool flag, double num, string str);
//using TupleIntString = (int, string);
using unsafe sp = System.Span<int>*;
using D = dynamic[];
using unsafe UnsafeT = System.Numerics.BigInteger; //remove unsafe modifier

namespace UsingAlias
{
    using TupleIntString = (int, string); //use this type alias where possible
    using TupleIS = (int, string);
    using TupleRef = Tuple<int, int>;
    using ArrMulti = double[,,];
    using ArrJagged = char[][];
    using NVT = int?;
    //using NRT = string?; 
    using NRTInside = List<string?>;
    using Dyn = dynamic;
    using unsafe sp = Span<int>*;
    using static UnsafeT;
    //using UnsafeInt = int*; //Make using directive unsafe
    //unsafe using Test = string;
    using UserType = TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw;
    using unsafe TypeUnsafe = TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw*;
    using unsafe D = delegate* unmanaged[Stdcall, SuppressGCTransition]<int, int>;
    using unsafe Del = delegate* unmanaged<string, delegate*<int>>;
    using unsafe Deleg = delegate*<delegate* managed<string, int>, delegate*<string, int>>;
    using unsafe EnumT = MyEnum;
    using static unsafe TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw;
    //using unsafe static Instance; //Move 'unsafe' modifier after 'static'

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //InstanceMethod();
            TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw t =
                new TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw();
            ArrInt array = new int[] { };
            UnsafeT variable = Zero;
            System.Security.Cryptography.Aes tAes = Aes.Create();
            System.Security.SecureString secureString = new System.Security.SecureString();
            int tempCompare = string.Compare("a", 4, "b", 5, 7, CultureInfo.CurrentCulture, CompareOptions.IgnoreCase);
        }


        public void tt()
        {
            unsafe
            {
                static void Foo(List<Arr> arg)
                {
                        Bar(arg); //create from usage
                }
            }
        }

        private static unsafe void Bar(List<Arr> intsList)
        {
            throw new NotImplementedException();
        }


        static void DoSmth(List<int> list, UserType userType) //change signature
        {

        }


    }
    public delegate void FooBarDelegate(String x);

    public class TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw
    {
        private TupleIntString t = (10, "sfsff");

        public static void Method() {}
    }

    public class CheckUseThisTypeAlias //generate code
    {
        private (int, string) tuple;

        public CheckUseThisTypeAlias(Util u)
        {
            this.u = u;
        }

        //public int CompareTo(object? other, IComparer comparer)
        //{
        //    return ((IStructuralComparable)tuple).CompareTo(other, comparer);
        //}

        public int Length => ((System.Runtime.CompilerServices.ITuple)tuple).Length;

        private Util u;

        protected bool Equals(CheckUseThisTypeAlias other)
        {
            return tuple.Equals(other.tuple) && u.Equals(other.u);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CheckUseThisTypeAlias)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(tuple, u);
        }

        public Util U1
        {
            get => u;
            set => u = value ?? throw new ArgumentNullException(nameof(value));
        }

        public (int, string) Tuple => tuple;

        public Util U => u;

        public unsafe void Deconstruct(out D del)
        {
            u.Deconstruct(out del);
        }

        public void Method()
        {
            tuple = (3, "6");
        }
    }
    public unsafe class Util
    {
        public void Deconstruct(out D del)
        {
            del = Del;
        }

        private D Del;
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
