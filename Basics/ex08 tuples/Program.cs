using System;

namespace ex08 {
    class Program {
        static void Main(string[] args) {
            // immutable tuple!
            Tuple<string, int> x = new Tuple<string, int>("tjena", 5);

            Console.WriteLine(x.Item1);  // cmd: tjena
            Console.WriteLine(x.Item2);  // cmd: 5
        }
    }
}
