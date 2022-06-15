using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsIntro
{
    public class BankAccount
    {
        protected float balance;

        //ENKAPSULACJA
        public string Name { get; set; }

        //private string name;

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}


        public void MakeDeposit(float amount)
        {
            if(amount < 0)
            {
                throw new Exception("Ammount must be positive number");
            }

            balance += amount;
        }

        //POLIMORFIZM
        public virtual void MakeWithdrawal(float amount)
        {
      
        }


        public void GetBalance()
        {        
            Console.WriteLine("Account balance: " + balance);
        }


        public int Number { get; set; }

        private int number;
    }
}



