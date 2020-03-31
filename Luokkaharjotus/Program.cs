using System;
using System.Collections.Generic;

namespace Luokkaharjotus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> tyypit = new List<Person>();
            tyypit.Add(new Person("Matti", 30, 900));
            tyypit.Add(new Person("Timo", 26, 1300));
            tyypit.Add(new Person("Toni", 34, 2100));

            foreach (var dude in tyypit)
            {
                Console.WriteLine($"nimi: {dude.name} ikä: {dude.age} palkka: {dude.salary}");
            }

            int yhteinenikä = 0;
            foreach (Person dude in tyypit)
            {
                yhteinenikä += dude.age;
            }
            Console.WriteLine(yhteinenikä);
            
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            Person person4 = new Person("Mikko", 38);
            Person person5 = new Person("Tommi", 41);
            Person ystävä1 = new Person("Pekka");
            Person ystävä2 = new Person("Juuso");
            Person ystävä3 = new Person("Antti");
            ystävä1.friend = ystävä3;
            ystävä3.friend = ystävä2;

            person1.name = "Pauli";
            person1.name = "Matti";
            person1.age = 28;
            person1.age = 30;
            person1.salary = 900;
            person1.salary = 1100;

            person2.name = "Kalle";
            person2.name = "Timo";
            person2.age = 20;
            person2.age = 26;
            person2.salary = 1500;
            person2.salary = 1300;

            person3.name = "Toni";
            person3.age = 34;
            person3.salary = 2100;

            Console.WriteLine(person1.name);
            Console.WriteLine(person1.age);
            Console.WriteLine(person1.salary);

            Console.WriteLine(person2.name);
            Console.WriteLine(person2.age);
            Console.WriteLine(person2.salary);

            Console.WriteLine(person3.name);
            Console.WriteLine(person3.age);
            Console.WriteLine(person3.salary);

            Console.WriteLine($"{person4.name} {person4.age}");
            Console.WriteLine($"{person5.name} {person5.age}");

            Console.WriteLine($"{ystävä1.name} kaveinaan hänellä onpi: { ystävä1.friend.name}");
            Console.WriteLine($"{ystävä3.name} kaveinaan hänellä onpi: { ystävä3.friend.name}");

        }
    }
}
