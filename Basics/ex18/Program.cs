using System;

namespace ex18 {
    // these are like discriminated unions:
    public class Name : Exception {
        public string value { get; set; }
    }
    public class Age : Exception {
        public int value { get; set; }
    }
    public class Person : Exception {
        public Exception value1 { get; set; }
        public Exception value2 { get; set; }
    }
    class Program {
        static void Main(string[] args) {
            Person John = new Person {
                value1 = new Name { value = "John" },
                value2 = new Name { value = "Smith" }
            };

            string s0 = PatternMatch(John);
            string s1 = PatternMatch(new Age { value = 42 });
            Console.WriteLine(s0);
            Console.WriteLine(s1);
        }

        public static string PatternMatch(Exception e) {
            try { throw e; }
            catch (Name n) { return n.value; }
            catch (Age x) { return x.value.ToString(); }
            catch (Person p) { return PatternMatch(p.value1) + PatternMatch(p.value2); }
            // beware recursion in C#!
        }
    }
}