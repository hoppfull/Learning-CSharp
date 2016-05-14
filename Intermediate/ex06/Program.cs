using System;

namespace ex06 {
    class Program {
        static void Main(string[] args) {
            MyClassParent p = new MyClassParent();
            MyClassChild c = new MyClassChild();

            p.PrintXandY();  // 117
            c.PrintXandY();  // 117
            c.PrintY();  // 7
        }
    }

    class MyClassParent {
        // x is only accessible to this class:
        private int x = 11;
        // y is only accessible to this class and its children:
        protected int y = 7;

        public void PrintXandY() {
            Console.Write(x);
            Console.WriteLine(y);
        }
    }

    class MyClassChild : MyClassParent {
        public void PrintY() {
            Console.WriteLine(y);
        }
    }
}
