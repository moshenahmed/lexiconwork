using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
      class PersonHandler 
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person people = new Person();
            people.Age=age;
            people.FName = fname;
            people.LName = lname;
            people.Height = height;
            people.Weight = weight;




            return people ;
        }

      
    }
}
