using System;
using Features_ConsoleApp.Events;

namespace Features_ConsoleApp
{
    class Delegates
    {
        // 1. We create a delegate type where we define it's signature (return type and its parameters)
        public delegate int myDelegate(int first, int second);

        // Function that matches delegate type signature above can be attaced to that delegate
        public static int foo(int first, int second)
        {
            return first + second;
        }

        public static void demonstrate()
        {
            // Variable with delegate type is declared and function attached to it
            myDelegate foo_delegate_var = foo;

            // This delegate variable can now be passed around and invoked instead of a function
            Console.WriteLine("foo_delegate_var: " + foo_delegate_var.Invoke(23, 32));

            // Action and Func delegates are built in delegates provided by .NET. With Func, return type generic is defined last. So no need to declare our own delegates.
            Func<int, int, int> d_foo = foo;
            Console.WriteLine("d_foo: " + d_foo(11, 11));
        }
    }

    // Extension methods are created by creating static class with public static method. This method accepts parameter
    // which has a type we are extending with keyword "this" in front + any additional parameters after.
    static class ExtensionMethods
    {
        public static void compare(this string first_string, string second_string)
        {
            if (first_string == second_string)
            {
                Console.WriteLine("strings equal");
            } else
            {
                Console.WriteLine("string not equal");
            }
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Delegates.demonstrate();

<<<<<<< HEAD
            string some_string = "champs";
            some_string.compare("champs");
=======
            Event my_event = new Event();
            my_event.demonstrate();
>>>>>>> f9dd0778d48271d61f0f15d1a074123329279919
        }
    }
}