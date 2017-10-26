using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class Bird : Animal
    {
     
        private int wingspan;

        public int WingSpan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }
        public Bird() { }
        public  Bird(int age, double weight, string name, int wingspan ) : base (age,weight,name)
{
            WingSpan = wingspan;
            } 

    }
}
