using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsIntro
{

    //DZIEDZICZENIE
    class PersonalBankAccount : BankAccount
    {
        public void RequestPersonalLoan(float amount)
        {
            Console.WriteLine("Taking Loan");
        }

        //POLIMORFIZM
        public override void MakeWithdrawal(float amount)
        {
            Console.WriteLine("Personal bank account withdrawl");
            if (amount < 0)
            {
                throw new Exception("Ammount must be positive number");
            }

            if (amount > balance)
            {
                throw new Exception($"Personal bank account can't go in debt.");
            }

            balance -= amount;
        }
    }
}
