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

        public Person(string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        //public Person()
        //{

        //}

        //public Person (Person friend)
        //{
        //    this.friend = friend;
        //}

        //public Person (string name, int age)
        //{
        //    this.name = name;
        //    this.age = age;
        //}
    }
    
}
