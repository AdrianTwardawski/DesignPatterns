using DesignPatterns;
using System;

namespace DesignPatternsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPrinter printer = new Canon();
            //IPrinter printer = GetPrinter();
            //printer.Print("some content");

            //    BankAccount bankAccount = GetBankAccount();
            //    bankAccount.Name = "Some bank account";
            //    Console.WriteLine(bankAccount.Name);
            //    bankAccount.MakeWithdrawal(2000);
            //    bankAccount.GetBalance();

            var polimorfizm = new Polimorfizm();
            var result = polimorfizm.SomeMethod(6, "CHUJ");
            Console.WriteLine(result);


            //    EmailSender emailSender = new EmailSender();

            //    emailSender.SendEmail("to@gmail.com", "title", "body");


            //}

            //static BankAccount GetBankAccount()
            //{
            //    var bankAccount = new CompanyBankAccount();
            //    bankAccount.MakeDeposit(1000);

            //    return bankAccount;
            //}

            //static IPrinter GetPrinter()
            //{
            //    return new Canon();
            //}
        }
    }
}

//W ten sposób możemy pozbyć się bezpośreniej zależności do konkretnej klasy w klasie Program. Można zauważyc, że nadal
//używamy konkretnego typu jakim jest Canon. W prawdziwych programach do tego użylibyśmy kontenera zależności.

// Interfejsy - są to kontrakty, w których definiujemy grupę powiązanych funkcjonalności, a następnie konkretne klasy, które
//implementują konkretny interfejs muszą dla tych metod dostarczyć swoją implementację.