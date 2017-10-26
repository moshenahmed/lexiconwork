using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Person
    {
        private int age;
        private double weight;
        private double height;
        private string lName;
        private string fName;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
    }
}
