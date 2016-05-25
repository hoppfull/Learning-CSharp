using System;

namespace ex09 {
    class Program {
        static void Main(string[] args) {
            Func<int, int, int> f = (x, y) => x * 2 + y;

            Console.WriteLine(f(100, 5));  // cmd: 205
        }
    }
}
