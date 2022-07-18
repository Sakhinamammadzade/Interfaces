using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
         {

       

            ICustomerDal[] customersDal = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OraceleCustomerDal()
            };

            foreach (var customerDal in customersDal)
            {
                customerDal.Add();
            }



            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            
            //IPerson person=new Customer();
            //PersonManager personManager = new PersonManager();
            //Students students = new Students();
            //Worker worker = new Worker();   
            //Customer customer = new Customer
            //{
            //    Age = 18,
            //    Name = "zeyneb",
            //    LastName = "memmedzade"
            //};
            //personManager.Add(students);
            //personManager.Add(worker);

            
           

          
            
           


        }

        interface IPerson
        {
            int Id { get; set; }
            string Name { get; set; }
            string LastName { get; set; }
            int Age { get; set; }

            
           
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set ; }
            public string LastName { get; set; }
            public string Work { get ; set ; }
            public int age { get; set; }
            public int Age { get; set; }
        }

        class Students : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public int age { get ; set ; }
            public int Age { get ; set; }
        }

        class Worker : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine("deneme");
            }

        }
    }
}
