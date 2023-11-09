using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageProject;
using Pack = PackageProject.PackageClass;
using T = (PackageProject.PackageClass, SharedProject.Class1);
using Arr = PackageProject.PackageClass[];
using unsafe UnsafeArr = PackageProject.PackageClass*[];
using unsafe UnsafeClass = PackageProject.PackageClass*;

namespace UsingAlias_Core
{
    using Tt = (Pack, PackageClass);
    using Type = PackageProject.PackageClass;
    using CustList = List<PackageClass?>;
    internal class PackageUsage
    {
        private T tesTuple;
        private Tt tTuple;

        public void Method()
        {
            Arr testPackageClasses = new PackageClass[4];
            foreach (var testPackageClass in testPackageClasses)
            {
                var tmp = testPackageClass.Prop;
            }
            var item1 = tesTuple.Item1.Field + tesTuple.Item2.Tm.Item1;
            var item2 = tTuple.Item1.Prop + tTuple.Item2.Prop;
            CustList list = new CustList(){new PackageClass("", 1)};
            Console.WriteLine(list[0].Field);
        }

        public unsafe void Method2()
        {
            UnsafeArr arr = new PackageClass*[5];
            for (var i = 0; i < arr.Length; i++)
            {
                var tmp = new Pack("d", 5);
                arr[i] = &tmp;
            }
            Type tClass = new Type("", 4);
            UnsafeClass exp = &tClass;
        }
    }
}
