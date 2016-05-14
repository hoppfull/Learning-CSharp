using System;

namespace ex16 {
    class Program {
        static void Main(string[] args) {
            Person p1 = new Person("Kalle Anka", 10);
            Console.WriteLine($"Name: {p1.name}, Age: {p1.age}");
        }

        public struct Person {
            readonly public string name;
            readonly public int age;
            public Person(string name, int age) {
                this.name = name;
                this.age = age;
            }
        }
    }
}
