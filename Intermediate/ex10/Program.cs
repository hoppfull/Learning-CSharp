using System;

namespace ex10 {
    class Program {
        static void Main(string[] args) {
            MyStruct o = new MyStruct();
            o.x = 7;
            o.y = 5;

            Console.WriteLine(o.x);  // 7
            Console.WriteLine(o.y);  // 5
        }

        // Structs are like classes, except they have no inheritance logic
        public struct MyStruct {
            public int x;
            public int y;
        }  // When passed as arguments, structs are passed as copies
    }
}
