//using Text // TODO: completion of using alias
//using Text =  //types
//using static unsafe 
//using unsafe 
//using unsafe D = 
using unsafe PPint = int**;
using ArrMulti = double[,,];
using ArrJagged = char[][];
using NVT = int?;
using unsafe Deleg = delegate*<void> ;

using TParam = (int, string);
namespace UsingAlias_Core;

public class Generic
{
	public void Test<TParam>()
	{
		//T // TODO: completion when type parameter has the same name
	}

	public void Test2()
	{
        unsafe
        {
            TParam t = GetTParamTuple();
		

            TParam GetTParamTuple()
            {
                return new(1, "Jane Doe");
            }


            int t2 = 1;

            //(int, string) t3 = ; // TODO: smart completion


            int GetInt()
            {
                return 1;
            }

            //ArrInt arrInts = 
            //TParam testValueTuple = 
            //PPint
            NVT i = t2;
            //ArrJagged chars = new ArrJagged[][];
            Deleg p = (Deleg)(&i);
        }
    }

    public TParam GetTParamTuple2()
    {
        (int, string) t = (5, "tsrt");
        TParam teTuple = (234324, "string");
		//return 
    }
}