using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class Animal
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal() { }
        public Animal(int age, int weight, string name)
        {
            Age = age;
            Weight = weight;
            Name = name;
        }

    }
}
