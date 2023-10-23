using System.Globalization;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Input; //Namespace imports page - no suggestion to remove unused
using System.Drawing; //remove unused
using ProjectReference;
using SharedProject;
using unsafe VoidTest = void*; //Support of types containing pointers - void
using unsafe UnsafeInt = int*; //Support of types containing pointers - built-in type
using unsafe PPint = int**; //Support of types containing pointers - pointer to a pointer
using unsafe Arr = int*[]; //Support of types containing pointers - array of pointers
using TupleNamed = (bool flag, double num, string str); //Types - tuple named
//using TupleIntString = (int, string);
using unsafe sp = System.Span<int>*;
using D = dynamic[]; //Types - dynamic
using unsafe UnsafeT = System.Numerics.BigInteger; //Quick-fixes for unsafe - remove unsafe modifier
using StrB = (string, bool);

namespace UsingAlias
{
    using TupleIntString = (int, string); //Context actions - inline type alias
    using TupleIS = (int, string); //Types - tuple unnamed
    using TupleRef = Tuple<int, int>;
    using ArrMulti = double[,,]; //Types - array - multidimensional
    using ArrJagged = char[][]; //Types - array - jagged
    using NVT = int?; //Types - nullable value type
    using NRT = string?;  //Types - nullable reference type - top-level (not supported)
    using NRTInside = List<string?>; //Types - nullable reference type - not top-level  supported
    using Dyn = dynamic; //Types - dynamic
    using unsafe sp = Span<int>*;
    using static UnsafeT; //Support of types containing pointers - using static
    using UnsafeInt = int*; //Quick-fixes for unsafe - Make using directive unsafe
    //unsafe using Test = string;
    using UserType = TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw; //Types - user defined type
    using unsafe TypeUnsafe = TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw*; //Support of types containing pointers - custom type
    using unsafe D = delegate* unmanaged[Stdcall, SuppressGCTransition]<int, int>; //Support of types containing pointers - delegate
    using unsafe Del = delegate* unmanaged<string, delegate*<int>>; //Support of types containing pointers - delegate
    using unsafe Deleg = delegate*<delegate* managed<string, int>, delegate*<string, int>>; //Support of types containing pointers - delegate
    using unsafe EnumT = MyEnum; //Support of types containing pointers - enum
    using static unsafe TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw; //Support of types containing pointers - using static
    using unsafe static Instance; //Quick-fixes for unsafe - Move 'unsafe' modifier after 'static'

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
            System.Security.Cryptography.Aes tAes = Aes.Create(); //Namespace imports page - no suggestion to remove namespace
            System.Security.SecureString secureString = new System.Security.SecureString(); //remove redundant
            int tempCompare = string.Compare("a", 4, "b", 5, 7, CultureInfo.CurrentCulture, CompareOptions.IgnoreCase);
            Class1 tClass1 = new Class1(("", true))
            {
                Tm = ("t", true)
            };
        }


        public void tt()
        {
            unsafe
            {
                static void Foo(List<Arr> arg)
                {
                        Bar(arg); //R# features - create from usage unsafe
                }
            }
        }

        private static unsafe void Bar(List<Arr> intsList)
        {
            throw new NotImplementedException();
        }


        static void DoSmth(List<int> list, UserType userType) //R# features - refactorings - change signature
        {

        }


    }
    public delegate void FooBarDelegate(String x);

    public class TypeWithLongNamewefsfsdvfsdvgsdgadsfwarweqfdshvbjhdbvsbdjfsdkhfkahsdjkcnjnxjnckjsdhfw
    {
        private TupleIntString t = (10, "sfsff");

        public static void Method() {}
    }

    public class CheckUseThisTypeAlias //R features - generate code
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
            delegate*<void> ptr1 = &Util.Log; //Context actions - introduce type alias on 'delegate*<void>'
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
