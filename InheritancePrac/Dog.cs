using System;

namespace InheritancePrac
{
    public class Dog : Animal
    {
        public string Color { get; set; }

        public Dog() {}

        public Dog(int age) : base(age) {}

        public void Bark()
        {
            Console.WriteLine("왈왈 짓습니다");
        }
        public new void Eat()
        {
            Console.WriteLine("허겁지겁 먹습니다.");
        }

        public void TestB()
        {
            //Private();
            Protected();
            Public();
        }
    }
}