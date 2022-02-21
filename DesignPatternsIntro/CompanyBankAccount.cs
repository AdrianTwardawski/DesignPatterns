using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsIntro
{

    //DZIEDZICZENIE
    public class CompanyBankAccount : BankAccount
    {
        public void RequestCompanyLoan(float amount)
        {
            Console.WriteLine("Taking Company Loan");
        }

        //POLIMORFIZM
        public override void MakeWithdrawal(float amount)
        {
            Console.WriteLine("Company bank account withdrawl");
            if (amount < 0)
            {
                throw new Exception("Ammount must be positive number");
            }
           
            balance -= amount;
        }
    }
}
