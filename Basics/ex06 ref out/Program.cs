using System;

namespace ex06 {
    class Program {
        static void Main(string[] args) {
            int x = 0;

            Inc(ref x);
            Inc(ref x);
            Inc(ref x);
            Console.WriteLine(x);  //cmd: 3
            One(out x);
            Console.WriteLine(x);  //cmd: 1
        }

        static void One(out int variable) {
            // variable >has< to be assigned apparently:
            variable = 1;
            int y = variable + 1;
            variable = y;
        }

        static void Inc(ref int variable) {
            int y = variable + 1;
            variable = y;
        }
    }
}
// http://www.c-sharpcorner.com/UploadFile/ff2f08/ref-vs-out-keywords-in-C-Sharp/