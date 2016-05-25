using System;

namespace ex09 {
    class Program {
        static void Main(string[] args) {
            MyClass myObject = new MyClass();

            myObject.Print("Hello!");  // Hello!
            Console.WriteLine(myObject.Calculate(5, 6));  // 30
        }
    }

    // An interface conatins no implementation, only type signatures:
    interface MyInterface {
        int Calculate(int value1, int value2);
        void Print(string message);
    }

    class MyClass : MyInterface {
        public int Calculate(int a, int b) {
            return a * b;
        }

        public void Print(string msg) {
            Console.WriteLine(msg);
        }
    }
}
