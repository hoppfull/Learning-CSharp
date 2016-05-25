using System;

namespace ex12 {
    class Program {
        static void Main(string[] args) {
            // A function f with type signature (int -> int) is defined:
            Func<int, int> f = x => x * 2;

            Console.WriteLine(f(1));  // 2
            Console.WriteLine(f(5));  // 10
            Console.WriteLine(f(3));  // 6
            Console.WriteLine(f(9));  // 18
        }
    }
}
