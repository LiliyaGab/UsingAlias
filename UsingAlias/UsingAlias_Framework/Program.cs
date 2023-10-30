using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SharedProject;
using unsafe PPint = int*;
using OOO = (SharedProject.Class1, string); 
using newAlias = int[];

namespace Framework
{
    using TupleIntString = (int, string);
    internal class Program
    {
        static void Main(string[] args)
        {
	        TupleIntString t = (5, "6");
	        NewMethod2(new[] { 1, 2, 3, 4, 5 }, new int[] { });
        }

        private static void NewMethod2(newAlias a, newAlias b)
        {
	        for (var index = 0; index < a.Length; index++)
	        {
		        b[index] = a[index];
	        }

	        Console.WriteLine(b);
        }

		private static void NewMethod()
        {
	        newAlias a = new []{1,2,3,4,5}; // TODO: Introduce Parameter refactoring
	        newAlias b = new int[] { };

	        for (var index = 0; index < a.Length; index++)
	        {
		        b[index] = a[index];
	        }

	        Console.WriteLine(b);
        }

        static unsafe void SquarePtrParam(PPint p)
        {
            *p *= *p;
        }

        public OOO GetOOO(Class1 class1)
        {
	        return new OOO(class1, "Jane Doe");
        }
	}
}
