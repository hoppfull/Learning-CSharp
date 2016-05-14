namespace ex02 {
    class Program {
        static void Main(string[] args) {
            MyClass myObject = new MyClass();
            myObject.x = 5;  // x is available outside class scope
            //myObject.y = 7;  // y is not available outside class scope

            // Code yields error, cannot compile
        }
    }

    // These rules apply for both static and non-static classes!
    class MyClass {
        public int x;
        private int y;
    }
}
