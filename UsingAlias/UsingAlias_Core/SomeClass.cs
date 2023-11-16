using UnityEngine;
//using Random = System.Random;

namespace UsingAlias
{
    [Obsolete]
    public class SomeClass
    {
        public int T { get; }

        public void Method()
        {
            var rnd = UnityEngine.Random.Range(0,100); 
            Random rand = new Random(); //use class qf with enabled 'use using alias directive to resolve conflicts'
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
