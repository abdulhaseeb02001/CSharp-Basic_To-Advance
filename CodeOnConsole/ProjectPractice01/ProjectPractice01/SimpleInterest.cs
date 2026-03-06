using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice01
{
    internal class SimpleInterest
    {
        float p, r, t, si;
        internal void calSI() {
            Console.WriteLine("Enter the value of p");
            p = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the value of r");
            r = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the value of t");
            t = Convert.ToSingle(Console.ReadLine());
            si = (p * r * t) / 100;
            Console.WriteLine("Simple Interest is " + si);
        }
    }
}
