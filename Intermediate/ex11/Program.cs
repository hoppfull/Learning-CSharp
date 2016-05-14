using System;

namespace ex11 {
    class Program {
        static void Main(string[] args) {
            MyClass o = new MyClass(3, 42);

            Console.WriteLine(o.x);  // 7
            Console.WriteLine(o.y);  // 5
        }
    }

    class MyClass {
        /* A readonly variable can only be assigned a value
        during initialization or inside constructor scope. */
        public readonly int x = 42;
        // This is probably better, same effect:
        public int y { get; }

        public MyClass(int x, int y) {
            this.x = x;
            this.y = y;

            this.x = 7;
            this.y = 5;
        }
    }
}
