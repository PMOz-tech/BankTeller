using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTeller
{
    class Teller 
    {
        public string Name { get; set; }

      

        public double CustomerInfo()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("How much do you want to deposit?");
            var depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What type of account do you want to open?/n 1.Savings /n 2. Current /n 3. Kids Account");
            var  accountType = Console.ReadLine();
            if (accountType == "Savings")
            {
                Teller teller = new Teller();
                teller.SavingInterest(depositAmount);
            }
            return depositAmount;
        }


        public void SavingInterest(double depositAmount)
        {

          var  intrest = depositAmount / 100;
            Console.WriteLine("Your rate is " + intrest);

         

        }

        //public double  vatRate(double rate)
        //{
        //    double rateVat = rate;
        //    rateVat = 7.5;

        //    return rateVat;

            
            

        }

        
    }

   
}
