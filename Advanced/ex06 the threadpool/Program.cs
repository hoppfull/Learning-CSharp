using System;
using System.Threading;
using System.Threading.Tasks;

namespace ex06 {
    class Program {
        static void Main(string[] args) {
            // threadpool thread:
            Task.Factory.StartNew(MyMethod).Wait();
            // threadpool thread:
            Task.Run(() => MyMethod()).Wait();
            // threadpool thread:
            Task t0 = new Task(MyMethod);
            t0.Start();
            t0.Wait();

            // custom thread:
            Task.Factory.StartNew(MyMethod, TaskCreationOptions.LongRunning).Wait();

            // custom thread:
            Thread t1 = new Thread(MyMethod);
            t1.Start();

            /* The thread pool recycles threads when they're done to reduce
             * the massive overhead of creating new ones. If we define a
             * thread as LongRunning the thread is destroyed when task is
             * finished.
             */
        }

        private static void MyMethod() {
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread
                ? "Threadpool thread"
                : "Custom thread");
        }
    }
}
