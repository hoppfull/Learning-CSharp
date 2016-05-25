using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ex08 {
    class Program {
        static void Main(string[] args) {
            Task.Factory.StartNew(() => "hello")
                .ContinueWith(ts => Console.WriteLine(ts.Result))
                .Wait();

            Task[] tasks = new Task[4]
                .Select(_ => Task.Factory.StartNew(() => Thread.Sleep(1000)))
                .ToArray();

            Task.Factory.ContinueWhenAll(tasks, ts => Console.WriteLine("Tasks finished"))
                .Wait();
        }
    }
}
