using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class Dog : Animal
    {
        private int teeth;

        public int Teeth
        {
            get { return teeth; }
            set { teeth = value; }
        }
        public Dog() { }
        public Dog(int age, int weight, string name, int teeth) : base(age, weight, name)
        {
            Teeth = teeth;
        }
    }
}
