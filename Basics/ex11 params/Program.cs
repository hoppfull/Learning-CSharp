using System;
using System.Linq;

namespace ex11 {
    class Program {
        static void Main(string[] args) {
            // params allows variable number of arguments
            Console.WriteLine(MyAvg(1, 2, 3, 4));
        }

        static double MyAvg(params double[] args) {
            return args.Sum() / args.Length;
        }
    }
}
