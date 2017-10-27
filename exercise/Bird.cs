using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class Bird : Animal
    {
        private int wingSpan;

        public int WingSpan
        {
            get { return wingSpan; }
            set { wingSpan = value; }
        }
        public Bird() { }
        public Bird(int age, int weight, string name, int wingSpan) : base(age, weight, name)
        {
            WingSpan = wingSpan;
        }
        public override string Stats()
        {

            return base.Stats() +  WingSpan;
        }
    }
}
