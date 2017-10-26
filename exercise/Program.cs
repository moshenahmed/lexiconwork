using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            PersonHandler elf = new PersonHandler();
           
            Person p1 = new Person();
            p1 = elf.CreatePerson(1, "John", "Eriksson", 500, 100);

            //PersonHandler orc = new PersonHandler();
            //orc.CreatePerson(5, "Yay", "O", 900, 200);
            //Person p2 = new Person();
            //p2 = orc.CreatePerson

            Console.WriteLine(p1.Age);


        }
    }
}
