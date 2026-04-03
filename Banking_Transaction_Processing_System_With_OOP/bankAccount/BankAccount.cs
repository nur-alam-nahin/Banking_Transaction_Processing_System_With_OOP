using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Transaction_Processing_System_With_OOP.bankAccount
{
    class BankAccount
    {
        List<Entities.Customer> customers = new List<Entities.Customer>();



        // account creat section
        public void accountCreate()
        {
            Console.Write("Account Number = ");
            int accountId = Convert.ToInt32(Console.ReadLine());


            Console.Write("Account type (Saving/Business) =  ");
            string AcType = Console.ReadLine();


            Console.Write("Initial Balance = ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Entities.AccountType accountType = new Entities.AccountType(AcType);
            Entities.Customer cust = new Entities.Customer(accountId, balance, accountType);


            customers.Add(cust);
        }




        // diposit section
        public void deposit()
        {
            Console.Write("Account Number = ");
            int accountId = Convert.ToInt32(Console.ReadLine());


            Console.Write("Account type (Saving/Business) =  ");
            string AcType = Console.ReadLine();


            foreach (var c in customers)
            {
                if (AcType == c.getType().getAccountType() && accountId == c.getAccountNum())
                {
                    Console.Write("Diposite balance = ");
                    double balance = Convert.ToDouble(Console.ReadLine());


                    c.setdeposit(balance);

                    Console.WriteLine();
                    Console.WriteLine("Account Number = " + c.getAccountNum());
                    Console.WriteLine("Account Type = " + c.getType().getAccountType());

                    Console.WriteLine("Update balance = " + c.getBalance());
                    Console.WriteLine("Withdraw = " + c.getBalance());
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
            }
        }



        // withdraw section
        public void withdraw()
        {
            Console.Write("Account Number = ");
            int accountId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Account type (Saving/Business) =  ");
            string AcType = Console.ReadLine();



            foreach (var c in customers)
            {



                if (AcType == c.getType().getAccountType() && accountId == c.getAccountNum())
                {
                    Console.Write("withdraw balance = ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());

                    c.setWithdraw(withdraw);

                    Service.BankCalculation bankCalculation;
                    if (c.getType().getAccountType() == "Saving")
                    {
                        bankCalculation = new Service.SavingAccount(c);
                    }
                    else
                    {
                        bankCalculation = new Service.BusinessAccount(c);
                    }


                    double finalAmount = bankCalculation.calculation();
                    c.updateBalance(finalAmount);



                    Console.WriteLine();
                    Console.WriteLine("Account Number = " + c.getAccountNum());
                    Console.WriteLine("Account Type = " + c.getType().getAccountType());

                    Console.WriteLine("Update balance = " + c.getBalance());
                    Console.WriteLine("Withdraw = " + finalAmount);
                    Console.WriteLine();



                }
                else
                {
                    Console.WriteLine("Try Again");
                }



            }
        }



        // account chack section
        public void balanceCheck()
        {

            Console.Write("Account Number = ");
            int accountId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Account type (Saving/Business) =  ");
            string AcType = Console.ReadLine();


            foreach (var c in customers)
            {
                if (AcType == c.getType().getAccountType() && accountId == c.getAccountNum())
                {

                    Console.WriteLine("Account Number = " + c.getAccountNum());
                    Console.WriteLine("Account Type = " + c.getType().getAccountType());
                    Console.WriteLine("Main balance = " + c.getBalance());
                }
                else
                {
                    Console.WriteLine("Try Again");
                }


            }
        }
    }
}
