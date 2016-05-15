using System;
using System.Threading;
using System.Threading.Tasks;

namespace ex07 {
    class Program {
        static void Main(string[] args) {
            Task<int> t = Task.Factory.StartNew(() => {
                Thread.Sleep(500);
                return 1337;
            });
            
            Console.WriteLine($"Status: {t.Status}, completed: {t.IsCompleted}");
            // When we call for result, thread will wait till it gets the result:
            Console.WriteLine(t.Result);
            Console.WriteLine($"Status: {t.Status}, completed: {t.IsCompleted}");
        }
    }
}
