using System;
using System.Threading;

namespace ex04 {
    class Program {
        public static int MyProperty { get; set; }
        static void Main(string[] args) {
            MyProperty = 5;

            Thread t = new Thread(MyMethod);
            t.Start();

            Console.WriteLine(MyProperty); // 5
            MyProperty = 7;

            Thread.Sleep(1000);
            Console.WriteLine(MyProperty); // 42
        }

        public static void MyMethod() {
            Thread.Sleep(500);
            Console.WriteLine(MyProperty); // 7
            MyProperty = 42;
        }
    }
}
// This shows that both threads are accessing the same memory.
// I guess it's safe since it's executing only on one core...
