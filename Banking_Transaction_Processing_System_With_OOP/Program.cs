using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Transaction_Processing_System_With_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entities.Customer> customers = new List<Entities.Customer>();

            int num;

            do
            {
                Console.WriteLine();
                Console.WriteLine("----- Online_Course_Enrollment -----");
                Console.WriteLine("1. Deposit ");
                Console.WriteLine("2. Withdraw ");
                Console.WriteLine("3. Exite");
                Console.Write("Chose any number : ");

                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0 && num < 3)
                {
                    switch (num)
                    {
                        case 1:
                            Console.Write("Account Number = ");
                            int accountId  = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Diposite balance = ");
                            double balance = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Account type (Saving/Business) =  ");
                            string AcType = Console.ReadLine();



                            Entities.AccountType accountType = new Entities.AccountType(AcType);
                            Entities.Customer cust = new Entities.Customer(accountId, balance, accountType);


                            customers.Add(cust);
                            break;


                        case 2:


                            Console.Write("Account type (Saving/Business) =  ");
                            string AccType = Console.ReadLine();

                            Console.Write("Account Number = ");
                            int accNum = Convert.ToInt32(Console.ReadLine());


                            foreach (var c in customers)
                            {

                                Service.BankCalculation bankCalculation;
                                if (c.getType().getAccountType() == "Live")
                                {
                                   
                                }
                                else
                                {
                                    bankCalculation = new Service.BusinessAccount(c);
                                }

                                if (AccType == "Saving" && accNum == c.getAccountNum())
                                {
                                    
                                    Console.Write("withdraw balance = ");
                                    double withdraw = Convert.ToDouble(Console.ReadLine());

                                    if (c.getBalance() > 0)
                                    {
                                        if (c.getBalance() > withdraw &&  withdraw > 0 && 100000 >= withdraw)
                                        {
                                            c.setWithdraw(withdraw);
                                            bankCalculation = new Service.SavingAccount(c);
                                            Console.WriteLine();
                                            Console.WriteLine("Account Number = " + c.getAccountNum());
                                            Console.WriteLine("Account Type = " + c.getType().getAccountType());
                                            //Console.WriteLine("Main balance = " + c.getBalance());
                                            Console.WriteLine("Update balance = " + c.updateBalance());
                                            Console.WriteLine("Withdraw = " + bankCalculation.calculation());
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Try again");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Try again");
                                    }

                                }
                                if(AccType == "Business" && accNum == c.getAccountNum())
                                {
                                    Console.Write("withdraw balance = ");
                                    double withdraw = Convert.ToDouble(Console.ReadLine());

                                    if (c.getBalance() > 0)
                                    {
                                        if (c.getBalance() > withdraw && withdraw > 0)
                                        {
                                            c.setWithdraw(withdraw);
                                            bankCalculation = new Service.BusinessAccount(c);
                                            Console.WriteLine();
                                            Console.WriteLine("Account Number = " + c.getAccountNum());
                                            Console.WriteLine("Account Type = " + c.getType().getAccountType());
                                            //Console.WriteLine("Main balance = " + c.getBalance());
                                            Console.WriteLine("Update balance = " + c.updateBalance());
                                            Console.WriteLine("Withdraw = " + bankCalculation.calculation());
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Try again");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Try again");
                                    }
                                }


                            }
                            break;
                    }

                }
            } while (num != 3);
        }
    }
}
