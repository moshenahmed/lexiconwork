using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Bird : Animal
    {
        public Bird() {
        }
        private int wingspan;

        public int WingSpan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }
        
    }
}
