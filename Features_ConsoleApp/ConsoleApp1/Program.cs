﻿using System;
using System.Collections.Generic;

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

    class Program
    {
        static void Main(string[] args)
        {
            Delegates.demonstrate();
        }
    }
}