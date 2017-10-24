using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.age = age;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.weight = weight;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.height = height;
        }
        public void SetfName(Person pers, string fName)
        {
            pers.fName = fName;
        }
        public void SetlName(Person pers, string lName)
        {
            pers.lName = lName;
        }

        public Person CreatePerson(int age, string fname,
          string lname, double height, double weight)
        {
            return new Person();
        }
        

        
    }
}
