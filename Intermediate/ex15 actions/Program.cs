using System;

namespace ex15 {
    class Program {
        static void Main(string[] args) {
            Action<string> action = null;

            for (int i = 0; i < 10; i++)
                action += s => Console.WriteLine(s + i);

            action("hello");
            action("hej");

            /* To null check f before calling:
             * f?.Invoke("string");
             */
        }
    }
}
