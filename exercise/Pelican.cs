using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Pelican : Bird
    {
        private int runSpeed;

        public int RunSpeed
        {
            get { return runSpeed; }
            set { runSpeed = value; }
        }
        public Pelican() { }
        public Pelican(int age, int weight, string name, int wingSpan, int runSpeed) : base(age, weight, name, wingSpan)
        {
            RunSpeed = runSpeed;
        }
    }
}
