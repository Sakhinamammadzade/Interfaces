using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker [] workers = new IWorker[3]
            {
               new Manager(),
               new Worker(),
               new Robot()
            };

            foreach (var worker in workers)
            {
                worker.work();
            }

            IEat []eats=new IEat[2]
            {
                new Worker(),
                new Manager(),
            };
            foreach (var eat in eats)
            {
                eat.eat();
            }
        }

        interface IWorker
        {
            void work();
           
           
        }


        interface IEat
        {
            void eat();
        }
        interface ISalary
        {
            void GetSalary();

        }

        class Worker : IWorker, ISalary, IEat
        {
            public void eat()
            {
                Console.WriteLine("worker ve managmente aiddi");
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void work()
            {
                Console.WriteLine("her 3ne aiddi");
            }
        }

        class Manager : IWorker, IEat, ISalary
        {
            public void eat()
            {
                Console.WriteLine("worker ve managmente aiddi");
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void work()
            {
                Console.WriteLine("her 3ne aiddi");
            }
        }

        class Robot : IWorker
        {
            public void work()
            {
                Console.WriteLine("her 3ne aiddi");
            }
        }

        //solid prinsipine gore bir sinif xususi sinif terefinden teleb olunmayan her hansi interfeys elementini heyeta kecire bilmez 
    }
}
