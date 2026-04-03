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

            bankAccount.BankAccount bankAccount = new bankAccount.BankAccount();

            int num;

            do
            {
                Console.WriteLine();
                Console.WriteLine("----- Online_Course_Enrollment -----");
                Console.WriteLine("1. Account create ");
                Console.WriteLine("2. Deposit ");
                Console.WriteLine("3. Withdraw ");
                Console.WriteLine("3. Balance check ");
                Console.Write("Chose any number : ");

                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0 && num < 5)
                {
                    switch (num)
                    {
                        case 1:
                            bankAccount.accountCreate();
                            break;

                        case 2:
                            bankAccount.deposit();
                            break;

                        case 3:
                            bankAccount.withdraw();
                            break;

                        case 4:
                            bankAccount.balanceCheck();
                            break;
                    }

                }
            } while (num != 5);
        }
    }
}
