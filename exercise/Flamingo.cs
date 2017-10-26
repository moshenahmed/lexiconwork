using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Flamingo: Bird
    {
        private int beaklength;

        public int Beaklength
        {
            get { return beaklength; }
            set { beaklength = value; }
        }
        public Flamingo() { }
        public Flamingo(int age, double weight, string name, int wingspan, int beaklength) : base (age, weight,name, wingspan)
        {
            Beaklength = beaklength;
        }
    }
}
