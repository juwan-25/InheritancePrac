using System;
using System.Security.Cryptography.X509Certificates;

namespace InheritancePrac
{
    public class Cat : Animal
    {
        public Cat() { }

        public Cat(int age) : base(age) { }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다");
        }
        public override void Eat()
        {
            Console.WriteLine("자박자박 먹습니다.");
        }
    }
}