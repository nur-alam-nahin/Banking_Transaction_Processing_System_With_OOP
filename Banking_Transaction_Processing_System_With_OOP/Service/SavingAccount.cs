using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking_Transaction_Processing_System_With_OOP.Entities;

namespace Banking_Transaction_Processing_System_With_OOP.Service
{
    class SavingAccount : BankCalculation
    {

        public SavingAccount(Customer customer):base(customer)
        {

        }

        

        public override double calculation()
        {

            if (_customer.getBalance() > _customer.getWithdraw() && _customer.getWithdraw() > 0 && _customer.getWithdraw() <= 100000)
            {

                return _customer.getWithdraw();
            }
            else
            {

                return 0;
            }

        }
    }
}
