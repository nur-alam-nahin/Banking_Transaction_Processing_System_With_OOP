using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Transaction_Processing_System_With_OOP.Entities
{
    class Customer
    {
        private int _accountNum;
        private double _balance;
        private double _withdraw;

        private AccountType _accountType;

        public Customer(int accountNum, double balance, AccountType accountType)
        {
            _accountNum = accountNum;
            _balance = balance;
            _accountType = accountType;
        }

        public int getAccountNum()
        {
            return _accountNum;
        }

        public double getBalance()
        {
            return _balance;
        }

        public AccountType getType()
        {
            return _accountType;
        }

        public void setWithdraw(double withdraw)
        {
            _withdraw = withdraw;
        }

        public double getWithdraw()
        {
            return _withdraw;
        }

        public double updateBalance()
        {
            _balance = _balance - _withdraw;

            return _balance;
        }

    }
}
