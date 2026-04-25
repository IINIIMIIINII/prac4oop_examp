using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace prac4oop_examp
{
    internal class Person
    {
        public string GetInfo()
        {
            string information = ("   Ім'я: " + this.name + "; Вік: " + this.age + "; Професія: " + this.profession + ";");
            return information;
        }

        string name, profession;
        int age;
        public Person(string name) {
            this.name = name;
        }
        public Person(string name, int age) { 
            this.name = name;
            this.age = age;
        }
        public Person(string name, string profession)
        {
            this.name = name;
            this.profession = profession;
        }
        public Person(string name, int age, string profession)
        {
            this.name = name;
            this.profession = profession;
            this.age = age;
        }
    }
}
