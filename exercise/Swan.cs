using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class Swan : Bird
    {
        private int neckLength;

        public int NeckLength
        {
            get { return neckLength; }
            set { neckLength = value; }
        }
        public Swan() { }
        public Swan(int age, int weight, string name, int wingSpan, int neckLength) : base(age, weight, name, wingSpan)
        {
            NeckLength = neckLength;
        }
        public override string Stats()
        {
            return base.Stats() + " " + NeckLength;
        }
    }
}
