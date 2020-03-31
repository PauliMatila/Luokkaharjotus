using System;
using System.Collections.Generic;
using System.Text;

namespace Luokkaharjotus
{
    public class Person
    {
        public string name;
        public int age;
        public int salary;
        public Person friend;

        public Person(string aName, int aAge, int aSalary)
        {
            this.name = aName;
            this.age = aAge;
            this.salary = aSalary;
        }

        public Person()
        {

        }

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    
}
