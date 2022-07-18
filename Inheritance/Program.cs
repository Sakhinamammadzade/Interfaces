using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Person [] person = new Person[3]
            {
                new Customer(),
                new Students(),
                new Person()
            };
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class Customer:Person
        {
            public string Email { get; set; }

        }

        class Students:Person
        {
            public int grade { get; set; }
        }


    }
}
