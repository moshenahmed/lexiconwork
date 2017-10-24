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
            age = people.Age ;
            fname = people.FName;
            lname = people.LName;
            height = people.Height;
            weight = people.Weight;




            return  new Person();
        }

        //public void SetAge (Person pers, int age)
        //{
        //   pers.Age = age;
        //}
       
        //public void SetHeight(Person pers, double height)
        //{
        //    pers.Height = height;
        //}
        //public void SetWeight(Person pers, double weight)
        //{
        //     pers.Weight = weight;
        //}
        //public void SetFname(Person pers, string fname)
        //{
        //    fname = pers.FName;
        //}
        //public void SetHeight(Person pers, string lname)
        //{
        //    lname = pers.LName;
        //}
    }
}
