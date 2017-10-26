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
            var p1 = new Person();
            PersonHandler Personone = new PersonHandler();

            p1 = Personone.CreatePerson(1, "jhdjdjd", "kdhdkjhd", 22.55, 66.66);
            Console.WriteLine(p1.Age);
        }
    }
}