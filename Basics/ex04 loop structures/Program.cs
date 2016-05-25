using System;

namespace ex04 {
    class Program {
        static void Main(string[] args) {
            int x = 5;
            while(true) {
                if (x > 20)
                    break;  // terminate loop
                Console.WriteLine(x);
                x++;  // increment x by one
            }

            for (  // normally written: "for(int i = 0; i < 10; i++)"
                int i = 0;  // start value
                i < 10;     // predicate (terminate if false)
                i++         // execute procedure every loop
                )
            {
                Console.WriteLine(i);
            }
        }
    }
}
