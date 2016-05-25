using System;

namespace ex13 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(MyMethodOne(x => x * 3));  // 15
            Console.WriteLine(MyMethodOne(x => x + 7));  // 12
            Console.WriteLine(MyMethodOne(x => x - 1));  // 4
            Console.WriteLine(MyMethodOne(x => x * x));  // 25

            Func<int, int> f1 = MyMethodTwo(10);
            Func<int, int> f2 = MyMethodTwo(1);

            Console.WriteLine(f1(1));  // 11
            Console.WriteLine(f1(2));  // 12
            Console.WriteLine(f1(3));  // 13

            Console.WriteLine(f2(1));  // 2
            Console.WriteLine(f2(3));  // 4
            Console.WriteLine(f2(8));  // 9
        }

        // This method takes a lambda as an argument:
        static int MyMethodOne(Func<int, int> f) {
            // 5 is passed to lambda and its value is returned:
            return f(5);
        }

        // This method returns a lambda:
        static Func<int, int> MyMethodTwo(int n) {
            // The returned function object remembers n from its closure:
            return x => x + n;
        }
    }
}
