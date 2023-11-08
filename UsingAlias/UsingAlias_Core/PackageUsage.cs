using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageProject;
using Pack = PackageProject.PackageClass;
using T = (PackageProject.PackageClass, SharedProject.Class1);

namespace UsingAlias_Core
{
    using Tt = (Pack, PackageClass);
    internal class PackageUsage
    {
        private T tesTuple;
        private Tt tTuple;

        public void Method()
        {
            var item1 = tesTuple.Item1.Field + tesTuple.Item2.Tm.Item1;
            var item2 = tTuple.Item1.Prop + tTuple.Item2.Prop;
        }
    }
}
