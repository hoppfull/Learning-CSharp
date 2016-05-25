using System;
using System.Threading.Tasks;

namespace ex05 {
    class Program {
        static void Main(string[] args) {
            Task t = new Task(() => Console.WriteLine("hello threading"));
            t.Start();
            /* If program ends, all tasks will
             * be killed before they're finished: */
            t.Wait();

            // Equivalent:

            Task.Run(() => Console.WriteLine("lolzc")).Wait();

            Task.Factory.StartNew(() => Console.WriteLine("haha")).Wait();
        }
    }
}
