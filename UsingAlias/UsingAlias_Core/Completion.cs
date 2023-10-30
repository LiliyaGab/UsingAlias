//using Text // TODO: completion of using alias

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
	}
}