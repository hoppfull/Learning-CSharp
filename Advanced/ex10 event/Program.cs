using System;

// https://msdn.microsoft.com/en-us/library/8627sbea.aspx
namespace ex10 {
    class Program {
        static void Main(string[] args) {
            MyClass myObj = new MyClass();
            Action f = () => Console.WriteLine("hello");

            myObj.MyAction += f; // cmd: "Function added!"
            myObj.MyAction += f; // cmd: "Function added!"
            myObj.MyAction += f; // cmd: "Function added!"
            myObj.MyAction -= f; // cmd: "Function removed!"

            // This is bad, the event keyword prevents this (encapsulation):
            myObj.BadEvent = () => Console.WriteLine("noo");
            myObj.BadEvent(); // cmd: "noo"

            // This is better, we cannot mess with the field itself from here:
            myObj.GoodEvent += () => Console.WriteLine("yay");
            // And we can't call it directly which is a good thing!

            myObj.MyMethod(); /*
            cmd: hello
            cmd: hello
            cmd: yay */
        }
    }

    class MyClass {
        public Action BadEvent;

        public event Action GoodEvent;

        private Action myAction;
        // We can explicitly specify what to do when adding and removing functions:
        public event Action MyAction {
            add {
                Console.WriteLine("Function added!");
                myAction += value;
            }
            remove {
                Console.WriteLine("Function removed!");
                myAction -= value;
            }
        }

        public void MyMethod() {
            // equivalent to myAction(); but doesn't execute if myAction == null:
            myAction?.Invoke();
            // equivalent to GoodEvent(); but doesn't execute if GoodEvent == null:
            GoodEvent?.Invoke();
        }
    }
}
