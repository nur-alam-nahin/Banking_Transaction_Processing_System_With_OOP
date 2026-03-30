using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking_Transaction_Processing_System_With_OOP.Entities;


namespace Banking_Transaction_Processing_System_With_OOP.Service
{
    class BusinessAccount : BankCalculation
    {

        public BusinessAccount(Customer customer) : base(customer)
        {

        }

        public override double calculation()
        {
            double charge = (_customer.getWithdraw() / 1000) * 5;
            double final = _customer.getWithdraw() - charge;

            return final;
        }
    }
}
