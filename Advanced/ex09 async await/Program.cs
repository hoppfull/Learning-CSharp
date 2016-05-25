using System;
using System.Threading;
using System.Threading.Tasks;

namespace ex09 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Start");
            // program continues after this function is called, before it is finished:
            MyMethod();
            Console.WriteLine("waiting...");
            Thread.Sleep(3000);
        }

        static async void MyMethod() {
            Console.WriteLine(await Task.Factory.StartNew(() => {
                Thread.Sleep(2000);
                return "Finished!";
            }));
        }
    }
}
