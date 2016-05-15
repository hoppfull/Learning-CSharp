using System;
using System.Linq;
using System.Collections.Generic;

namespace ex03 {
    class Program {
        static void Main(string[] args) {
            IEnumerable<int> xs = new int[] { 1, 2, 3, 4, 5 }
                .Where(x => x < 4)
                .Select(x => x * 2);

            foreach (int x in xs)
                Console.WriteLine(x);
        }
    }
}
