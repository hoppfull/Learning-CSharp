using System;

namespace ex14 {
    enum MyRecord {
        Record1 = 1,
        Record2 = 2,
        Record3 = 3
    }

    class Program {
        static Action<string> printfn = s => Console.WriteLine(s);
        static void Main(string[] args) {
            MyRecord x = MyRecord.Record1;
            MyRecord y = MyRecord.Record2;
            MyRecord z = MyRecord.Record3;

            printfn(PatternMatch(x));
            printfn(PatternMatch(y));
            printfn(PatternMatch(z));

            var xs = Enum.GetValues(typeof(MyRecord));
        }

        static string PatternMatch(MyRecord pattern) {
            switch (pattern) {
                case MyRecord.Record1:
                    return "pattern 1";
                case MyRecord.Record2:
                    return "pattern 2";
                case MyRecord.Record3:
                    return "pattern 3";
                default:
                    return "pattern _";
            }
        }
    }
}
