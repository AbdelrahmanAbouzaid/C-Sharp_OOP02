using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Child : Parent
    {
        public int z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        // override or hide 
        public new void Fun1()
        {
            Console.WriteLine("I am Derived [Child]");
        }
        public /*new*/ void Fun2()
        {
            Console.WriteLine($"X: {x}, Y: {y}, Z: {z}");
        }
        public override string ToString()
        {
            return $"X: {x}, Y: {y}, Z: {z}";
        }
    }
}
