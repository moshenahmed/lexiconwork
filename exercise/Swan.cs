using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Swan : Bird
    {
        private string sing;

        public string Sing
        {
            get { return sing; }
            set { sing = value; }
        }

        public Swan() { }
        public Swan(int age, double weight, string name, int wingspan, string sing) : base(age, weight, name, wingspan)
        {
            Sing = sing;
        }
    }
}
