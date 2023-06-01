using System;
namespace InheritancePrac
{
    public class Animal
    {
        public int Age { get; set; }

        Animal() 
        { 
            this.Age = 0;
        }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잡니다");
        }

        private void Private() { }
        protected void Protected() { }
        public void Public() { }

        public void TestA()
        {
            Private();
            Protected();
            Public();
        }
    }
}