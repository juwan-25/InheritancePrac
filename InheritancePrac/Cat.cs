using System;
using System.Security.Cryptography.X509Certificates;

namespace InheritancePrac
{
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다");
        }

    }
}