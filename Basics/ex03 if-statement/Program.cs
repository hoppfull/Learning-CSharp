using System;

namespace ex03 {
    class Program {
        static void Main(string[] args) {
            int x = 5;
            // control structure:
            if (x < 10) {
                Console.WriteLine("x är mindre än tio!");
            } else if (x < 5) {
                Console.WriteLine("x är mindre än fem!");
            } else {
                Console.WriteLine("x är inte mindre än fem eller tio!");
            }
        }
    }
}
