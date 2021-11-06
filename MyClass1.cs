namespace _0Delegate.App
{
    delegate Delegate5 Functional(Delegate3 delegate3, Delegate4 delegate4);
    delegate string Delegate3();
    delegate string Delegate4();
    delegate string Delegate5();
    class MyClass1
    {
        public static Delegate5 MethodFirst(Delegate3 delegate3, Delegate4 delegate4)
        {
            return delegate { return delegate3.Invoke() + delegate4.Invoke(); };
        }
        public static string MethodS() => "Hello";
     
        public static string MethodT()=>" Armenia";
      
    }
}
