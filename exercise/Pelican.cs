using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Pelican : Bird

    {
        private String feathercolor;

        public String FeatherColor
        {
            get { return feathercolor; }
            set { feathercolor = value; }
        }

        public Pelican() { }
        public Pelican(int age, double weight, string name, int wingspan, string feathercolor) :
            base(age, weight, name, wingspan)
        {
            FeatherColor = feathercolor;
        }


    }
}
