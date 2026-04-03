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

                if (num > 0 && num < 4)
                {
                    switch (num)
                    {
                        case 1:
                            Console.Write("Account Number = ");
                            int accountId  = Convert.ToInt32(Console.ReadLine());

                            

                            Console.Write("Account type (Saving/Business) =  ");
                            string AcType = Console.ReadLine();



                            Entities.AccountType accountType = new Entities.AccountType(AcType);
                            Entities.Customer cust = new Entities.Customer(accountId,0, accountType);


                            customers.Add(cust);
                            break;

                        case 2:

                            Console.Write("Account type (Saving/Business) =  ");
                            string AccoType = Console.ReadLine();

                            Console.Write("Account Number = ");
                            int acNum = Convert.ToInt32(Console.ReadLine());

                            foreach(var c in customers)
                            {
                                if (AccoType == "Saving" && acNum == c.getAccountNum())
                                {
                                    Console.Write("Diposite balance = ");
                                    double balance = Convert.ToDouble(Console.ReadLine());


                                    c.setdeposit(balance);
                                }
                            }

                            break;

                        case 3:


                            Console.Write("Account type (Saving/Business) =  ");
                            string AccType = Console.ReadLine();

                            Console.Write("Account Number = ");
                            int accNum = Convert.ToInt32(Console.ReadLine());


                            foreach (var c in customers)
                            {

                              

                                if (AccType == "Saving" && accNum == c.getAccountNum())
                                {
                                    Console.Write("withdraw balance = ");
                                    double withdraw = Convert.ToDouble(Console.ReadLine());

                                    c.setWithdraw(withdraw);

                                    Service.BankCalculation bankCalculation;
                                    if(c.getType().getAccountType() == "Saving")
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
                                    //Console.WriteLine("Main balance = " + c.getBalance());
                                    Console.WriteLine("Update balance = " + finalAmount);
                                    Console.WriteLine("Withdraw = " + bankCalculation.calculation());
                                    Console.WriteLine();

                                   
                                    if (c.getBalance() > 0)
                                    {
                                        if (c.getBalance() > withdraw &&  withdraw > 0 && 100000 >= withdraw)
                                        {
                                            
                                            
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

                        case 4:
                            foreach(var c in customers)
                            {
                                Console.WriteLine("Account Number = " + c.getAccountNum());
                                Console.WriteLine("Account Type = " + c.getType().getAccountType());
                                Console.WriteLine("Main balance = " + c.getBalance());


                            }
                            break;
                    }

                }
            } while (num != 5);
        }
    }
}
