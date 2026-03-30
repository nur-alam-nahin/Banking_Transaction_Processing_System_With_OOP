using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Transaction_Processing_System_With_OOP.Entities
{
    class AccountType
    {
        private string _accountType;

        
        public AccountType(string accType)
        {
            _accountType = accType;
        }


        public string getAccountType()
        {
            return _accountType;
        }
    }
}
