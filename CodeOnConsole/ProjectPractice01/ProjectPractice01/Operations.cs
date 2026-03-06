using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice01
{
    internal class Operations
    {
        int a, b, c;
        internal void Accept()
        {
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
        }
        internal void Add()
        {
            c = a + b;
            Console.WriteLine(c);
        }

        internal void Subtract()
        {
            c = a - b;
            Console.WriteLine(c);
        }

        internal void Multiply()
        {
            c = a * b;
            Console.WriteLine(c);
        }

        internal void Divide()
        {
            int a = 10, b = 20, c;
            c = a / b;
            Console.WriteLine(c);
        }
    }
}
