using System;

namespace ex03 {
    class Program {
        static void Main(string[] args) {
            MyClass o = new MyClass();
            o.MyFieldOne = 5;
            o.MyFieldTwo = 7;
            o.MyFieldThree = -5;

            Console.WriteLine(o.MyFieldOne);  // 5
            Console.WriteLine(o.MyFieldTwo);  // 7
            Console.WriteLine(o.MyFieldThree);  // 0
        }
    }

    // These rules apply for both static and non-static classes!
    class MyClass {
        // Folded form:
        public int MyFieldOne { get; set; }

        // Unfolded form:
        private int myfieldtwo;
        public int MyFieldTwo
        {
            get { return myfieldtwo; }
            set { myfieldtwo = value; }
        }

        // setter prevents negative values to be assigned:
        private int myfieldthree;
        public int MyFieldThree
        {
            get { return myfieldthree; }
            set { myfieldthree = value > 0 ? value : 0; }
        }
    }
}
