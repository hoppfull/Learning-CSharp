using System;

namespace ex07 {
    class Program {
        static void Main(string[] args) {
            int x = 5;  // x exists in sub-scope as well as local scope
            {  // define local scope
                int y = 7;  // y exists only in local scope
                Console.WriteLine(x + y);  // cmd: 12
            }
            Console.WriteLine(x);  // cmd: 5
        }
    }
}
