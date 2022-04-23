using System;

namespace ConsoleApp2
{
    public delegate void AddDelegate(int a, int b);
    public delegate string GreetingsDelegate(string name);
    partial class Program
    {
        public void Add(int x,int y)
        {
            Console.WriteLine(@"The Sum of {0} and {1}, is {2}",x,y,x+y);
        }
        public static string Greetings(string name)
        {
            return "Hello @" + name;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            // Instantiating the delegate by passing the function name
            AddDelegate ad = new AddDelegate(obj.Add);
            GreetingsDelegate gd = new GreetingsDelegate(Program.Greetings);
            // Invoking the Delegates
            ad.Invoke(20, 30);
            Console.WriteLine(gd.Invoke("Bilal") ); 
        }
    }
}



/*
 * What are delegates in C#?
Defination: In simple words we can say that the delegates in C# are the Type-Safe Function Pointer. It means they hold the reference of a method or function and then call that method for execution.
How many ways we can call a method in C#?
In C#, we can call a method that is defined in a class in two ways. They are as follows:
1.	We can call the method using the object of the class if it is a non-static method or we can call the method through class name if it is a static method.
2.	We can also call a method in C# by using delegates. Calling a C# method using delegate will be faster in execution as compared to the first process i.e. either by using an object or by using the class name.

How to invoke methods using Delegates in C#?
If you want to invoke or call a method using delegates then you need to follow three simple steps.  The steps are as follows.
1.	Defining a delegate
2.	Instantiating a delegate
3.	Invoking a delegate
<Access Modifier> delegate <return type> <delegate name> (arguments list);

The Delegates in C# are classified into two types such as

Single Cast Delegate
Multicast Delegate
If a delegate is used for invoking a single method then it is called a single cast delegate or unicast delegate. In other words, we can say that the delegates that represent only a single function are known as single cast delegates.

If a delegate is used for invoking multiple methods then it is known as the multicast delegate. Or the delegates that represent more than one function are called Multicast delegates.

 */