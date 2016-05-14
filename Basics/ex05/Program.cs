using System;

namespace ex05 {
    class Program {
        static void Main(string[] args) {
            int x = MyFunc(4);
            Console.WriteLine(x);  // cmd: 8
        }
        static int MyFunc(int arg) {
            return arg * 2;
        }
    }
}
// http://www.c-sharpcorner.com/UploadFile/ff2f08/ref-vs-out-keywords-in-C-Sharp/