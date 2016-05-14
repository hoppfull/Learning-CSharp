using System;

namespace ex07 {
    class Program {
        static void Main(string[] args) {
            MyClassChild o = new MyClassChild();

            Console.WriteLine(o.Calculate(8, 6));  // 48
            o.Print();  // hello
        }
    }

    // An abstract class can contain members that has to be implemented:
    abstract class MyClassParent {
        // An abstract method has to be overridden by child classes:
        abstract public void Print();

        public int Calculate(int x, int y) {
            return x * y;
        }
    }  // An abstract class cannot be instantiated!

    class MyClassChild : MyClassParent {
        public override void Print() {
            Console.WriteLine("hello");
        }
    }
}
