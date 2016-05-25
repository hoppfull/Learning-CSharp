using System;

namespace ex05 {
    // class "Program" inherits from class "MyClass":
    class Program : MyClass {
        static void Main(string[] args) {
            Console.WriteLine($"My name is {Name} and I am {Age} years old!");
        }
    }

    // "sealed" would prevent this class from being inherited from:
    class MyClass {
        static public int Age = 6;
        static public string Name = "John Smith";
    }
}
