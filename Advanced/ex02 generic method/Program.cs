using System;

namespace ex02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(MyMethod("Hello"));
            Console.WriteLine(MyMethod(5));
            Console.WriteLine(MyMethod(new DateTime(1988, 04, 23)));
        }

        static T MyMethod<T>(T arg) {
            return arg;
        }
    }
}
