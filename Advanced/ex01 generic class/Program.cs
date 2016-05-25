using System;

namespace ex01 {
    class Program {
        static void Main(string[] args) {
            var myObj = new MyClass<string>();
            myObj.Set("tjosan");
            Console.WriteLine(myObj.Get());
        }
    }

    // Class takes one type argument called "T":
    class MyClass<T> {
        private T MyField;
        public T Get() {
            return MyField;
        }

        public void Set(T value) {
            MyField = value;
        }
    } 
}
