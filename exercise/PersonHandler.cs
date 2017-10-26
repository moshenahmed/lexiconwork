using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class PersonHandler
    {



        public Person CreatePerson(int age, string fname,
          string lname, double height, double weight)
        {
            Person John = new Person();
            John.Age = age;
            John.FName = fname;
            John.LName = lname;
            John.Height = height;
            John.Weight = weight;
            return John;
        }


    }
} 
    

