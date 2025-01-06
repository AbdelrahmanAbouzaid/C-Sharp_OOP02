using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Parent
    {
        public int x { get; set; }
        public int y { get; set; }

        public Parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Fun1()
        {
            Console.WriteLine( "I am Based [Parent]");
        }
        public void Fun2()
        {
            Console.WriteLine($"X: {x}, Y: {y}");
        }
        public override string ToString()
        {
            return $"X: {x}, Y: {y}";
        }
    }
}
