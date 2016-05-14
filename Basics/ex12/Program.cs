using System;

namespace ex12 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(MyFunc(10));  // cmd: 50
            Console.WriteLine(MyFunc(3, 7));  // cmd: 21
        }

        static int MyFunc(int a, int b = 5) {  // b is optional parameter
            return a * b;
        }
    }
}
