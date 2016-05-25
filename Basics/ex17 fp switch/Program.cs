using System;

namespace ex17 {
    class Program {
        static Func<string, string> sprintf =
            a => string.Format($"case: {a}");
        static void Main(string[] args) {
            Func<string, string> f =
                s => s == "0" ? sprintf("zero")
                   : s == "1" ? sprintf("one")
                   : s == "2" ? sprintf("two")
                   : s == "3" ? sprintf("three")
                   : s == "4" ? sprintf("four")
                   : s == "5" ? sprintf("five")
                   : sprintf("default");
            
            Console.WriteLine(f("4"));
        }
    }
}