using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class Horse : Animal
    {
        private int hooves;

        public int Hooves
        {
            get { return hooves; }
            set { hooves = value; }
        }
        public Horse() { }
        public Horse(int age, int weight, string name, int hooves):base(age, weight, name)
        {
            Hooves = hooves;
        }
    }
}
