using System;

namespace ex04 {
    class Program {
        static void Main(string[] args) {
            MyClass o = new MyClass("A value for myfield!");
            /* "myfield" cannot be reassigned beyond this point. The initial
            value assigned during instantiation is safe forever! "myfield"
            can only be retrieved for reading by client code. */

            Console.WriteLine(o.MyField);  // A Value for myfield!
        }
    }

    class MyClass {
        private string myfield;
        // With no set, no assignment to myfield using this property:
        public string MyField { get { return myfield; } }

        // Constructor method runs when class is instantiated:
        public MyClass(string s) {
            myfield = s;
        }  // for static classes, constructor runs when application starts
    }
}
