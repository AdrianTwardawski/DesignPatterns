using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsIntro
{
    class Person
    {
        public string Name;
        public Person(string Name, int age)
        {
            this.Name = Name;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hello, my name is " + this.Name);
        }
    }
}
