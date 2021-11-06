using System;

namespace _0Delegate.App
{
    delegate Delegate2 Delegate1();
    delegate void Delegate2();
    static class MyClass
    {
        public static Delegate2 Method1()
        {
            return new Delegate2(Method2);
        }

        public static void Method2()
        {
            Console.WriteLine("Hello world!") ;
        }
    }
}
