using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAlias
{
    [Obsolete]
    public class SomeClass
    {
        public int T { get; }

        public void Method()
        {
            Console.WriteLine(T);
        }
    }

    [Obsolete]
    public class MyClass
    {
        public string S { get; }

        public void Method()
        {

        }
    }
}
