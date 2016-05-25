using System;

namespace ex01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(MyStaticClass.MyField);  // Hello static field
            Console.WriteLine(MyStaticClass.MyMethod(7, 5));  // 35

            // public static field can be reassignes:
            MyStaticClass.MyField = "New value for MyField";

            Console.WriteLine(MyStaticClass.MyField);  // New value for MyField
        }
    }

    static class MyStaticClass {
        public static string MyField = "Hello static field";

        public static int MyMethod(int x, int y) {
            return x * y;
        }
    }  // A static class cannot be instantiated. Members are accessed directly.
}
