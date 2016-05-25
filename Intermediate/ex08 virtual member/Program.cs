using System;

namespace ex08 {
    class Program {
        static void Main(string[] args) {
            MyClassParent p = new MyClassParent();
            MyClassChild c = new MyClassChild();

            Console.WriteLine(p.Calculate(5, 9));  // 45
            Console.WriteLine(c.Calculate(5, 9));  // 14

            Console.WriteLine(c.oldresult); // 45
        }
    }

    class MyClassParent {
        // A virtual method can be overriden by child classes:
        public virtual int Calculate(int x, int y) {
            return x * y;
        }
    }

    class MyClassChild : MyClassParent {
        public int oldresult;

        public override int Calculate(int x, int y) {
            oldresult = base.Calculate(x, y);  // base calls the parent class
            return x + y;
        }
    }
}
