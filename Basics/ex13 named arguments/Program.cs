using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(MyFunc(7, 5));  // cmd: 2
            Console.WriteLine(MyFunc(b:7, a:10));  // cmd: -2
        }

        static int MyFunc(int a, int b) {
            return a - b;
        }
    }
}
