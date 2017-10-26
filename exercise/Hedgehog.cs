using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class Hedgehog : Animal
    {
        private int spikes;

        public int Spikes
        {
            get { return spikes; }
            set { spikes = value; }
        }
        public Hedgehog() { }
        public Hedgehog(int age, int weight, string name, int spikes) : base(age, weight, name)
        {
            Spikes = spikes;
        }
    }
}