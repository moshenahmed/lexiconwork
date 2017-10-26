using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class Flamingo : Bird
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Flamingo() { }
        public Flamingo(int age, int weight, string name, int wingSpan, string color): base(age, weight, name, wingSpan)
        {
            Color = color;
        }
    }
}
