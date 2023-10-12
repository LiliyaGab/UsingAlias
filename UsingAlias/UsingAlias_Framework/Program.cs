using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using unsafe PPint = int*;

namespace Framework
{
    using TupleIntString = (int, string);
    internal class Program
    {
        static void Main(string[] args)
        {
            TupleIntString t = (5, "6");
        }
        static unsafe void SquarePtrParam(PPint p)
        {
            *p *= *p;
        }
    }
}
