using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking_Transaction_Processing_System_With_OOP.Entities;

namespace Banking_Transaction_Processing_System_With_OOP.Service
{
    abstract class BankCalculation
    {
        protected Entities.Customer _customer;

        protected BankCalculation(Customer cust)
        {
            _customer = cust;
        }

        public abstract double calculation();
    }
}
