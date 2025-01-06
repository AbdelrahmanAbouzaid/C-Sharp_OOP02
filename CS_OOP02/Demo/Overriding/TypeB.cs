using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        // override or hide
        // 1. Apply override using 'new' keyword
        // 2. Apply override using 'override' keyword

        // Static Binding
        // Compiler Will Bind Function Call Based On Reference Type Not the Object Type
        public new void Fun01()
        {
            Console.WriteLine("Fun01 from Type B");
        }
        // must be not private and virtual

        // Dynamic Binding
        // CLR Will Bind Function Call Based On Object Type Not the Reference Type
        // Runtime
        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}");
        }
    }
}
