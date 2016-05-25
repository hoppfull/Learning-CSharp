using System;

namespace ex14 {
    class Program {
        private delegate int MyTypeSig(int x, int y);

        static void Main(string[] args) {
            MyTypeSig f0 = (a, b) => a * b;
            Func<int, int, int> f1 = (a, b) => a * b;
            // f0 and f1 are equivalent
        }
    }
}
