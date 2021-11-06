using System;

namespace _0Delegate.App
{
    public delegate void MyDelegate();
    public delegate int MyDelegate1(int first, int second);
    public delegate void MyDelegate2(ref int first,ref int second,out int value);
    public delegate void MyDelegate3();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello world"); };
            myDelegate();
           
            Console.WriteLine(new string('_',50));
            int summand1 = 5;
            int summand2 = 7;
            int sum = 0;
            MyDelegate1 myDelegate1 = delegate (int first, int second) { return first + second; };
            sum = myDelegate1(summand1, summand2);
            Console.WriteLine($"{summand1}+{summand2}={sum}");
            
            Console.WriteLine(new string('_', 50));
            int summand3 = 10;
            int summand4 = 15;
            int sum1=0;
            MyDelegate2 myDelegate2 = delegate (ref int first,ref int second,out int value) { first++; second++; value = first + second; };
            myDelegate2(ref summand3,ref  summand4,out  sum1);
            Console.WriteLine($"{summand3}+{summand4}={sum1}");

            Console.WriteLine(new string('_', 50));
            MyDelegate3 myDelegate3;
            myDelegate3 = delegate { Console.WriteLine("Helo World!"); };
            myDelegate3 += () => { Console.WriteLine("Hello Armenia!"); };
            myDelegate3 += () => Console.WriteLine("Barev Hayastan!");
            myDelegate3();

            Console.WriteLine(new string('_', 50));
            Delegate1 delegate1 = new Delegate1(MyClass.Method1);
            Delegate2 delegate2 = delegate1.Invoke();
            delegate2.Invoke();

            Console.WriteLine(new string('_', 50));
            Functional functional = new Functional(MyClass1.MethodFirst);
            Delegate5 delegate5 = functional.Invoke(new Delegate3(MyClass1.MethodS), new Delegate4(MyClass1.MethodT));
            Console.WriteLine(delegate5.Invoke());

            Console.ReadLine();
        }
    }
}
