using System;

namespace ex15 {
    class Program {
        static void Main(string[] args) {
            Person p1 = new Person("Kalle Anka");
            p1.Age = -1;
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Age);
        }
    }

    class Person {
        private string name;
        private int age;

        public Person(string name, int age = 0) {
            this.name = name;
            this.age = age;
        }

        public string Name {
            get { return name; }
        }

        public int Age {
            get { return age; }
            set { age = value >= 0 ? value : 0; }
        }
    }
}
