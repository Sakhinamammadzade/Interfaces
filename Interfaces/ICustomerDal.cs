﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();  
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }
        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql uptadet");
        }
    }

    class OraceleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle added");
        }
    }

    class CustomerManager
    {
          public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
