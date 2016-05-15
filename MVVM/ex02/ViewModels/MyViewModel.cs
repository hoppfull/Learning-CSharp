using System;
using ex02.Commands;

namespace ex02.ViewModels {
    public class MyViewModel {
        public MyCommand PrintCommand { get; }
        public MyViewModel() {
            PrintCommand = new MyCommand(this);
        }
        public void MyMethod() {
            Console.WriteLine("hello");
        }
    }
}
