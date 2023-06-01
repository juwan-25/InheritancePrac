using System;
using System.Security.Cryptography.X509Certificates;

namespace InheritancePrac
{
    public class Cat
    {
        public int Age { get; set; }
        public string Color { get; set; }

        public Cat()
        {
            this.Age = 0; 
        }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잡니다");
        }
    }
}