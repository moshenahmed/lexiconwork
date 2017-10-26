using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class Horse : Animal
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Horse() { }
        public Horse(int age, double weight, string name, string color): base(age, weight, name)
        {
            Color = color;
        }

    }
}
