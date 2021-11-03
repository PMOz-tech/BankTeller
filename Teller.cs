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
        public double Rate { get; set; }



        public double CustomerInfo()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("Hello"+ " " + Name + "," + "how much do you want to deposit?");
            var depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What type of account do you want to open? \n Options are: \n Savings \n Current \n Kids Account");
            var accountType = Console.ReadLine();
            if (accountType == "Savings")
            {
                Rate = 0.50;
                var compoundInterest = CummulativeInterest(depositAmount, Rate);
                
                SavingInterest(compoundInterest, Rate);
            }
            else if(accountType == "Current")
            {
                Rate = 2.34;
                var compoundInterest = CummulativeInterest(depositAmount, Rate);
                CurrentInterest(compoundInterest, Rate);
            }
            else if (accountType == "Kids Account")
            {
                Rate = 1.5;
                var compoundInterest = CummulativeInterest(depositAmount, Rate);
                KidsAccount(compoundInterest, Rate);


            }
            return depositAmount;
        }



        public double[] CummulativeInterest(double depositAmount, double rate)
        {
            
            double[] compoundInterest = new double[5];
            double[] month = new double[5];
            month[0] = 0.5;
            month[1] = 0.75;
            month[2] = 1.0;
            month[3] = 2.0;
            month[4] = 5.0;
            //  double[] month = {0.5, 0.75, 1.0, 2.0, 5.0  };
            int x = 0;
            foreach (double i in month)
            {
                 compoundInterest[x] = depositAmount *(Math.Pow((1 + rate / 100),  i));
                x++;
            }

            return compoundInterest;
        }
        //public void SavingInterest(double depositAmount)
        //{

        // var  intrest = depositAmount / 100;
        // Console.WriteLine("Your rate is " + intrest);



        //}


        public void SavingInterest(double[] compoundInterest, double rate)
        {
            for(int i = 0; i < compoundInterest.Length; i++) 
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Your interest for 6 months is " + compoundInterest[0] + "  " + "and your rate is " + rate);
                        break;
                    case 1:
                        Console.WriteLine("Your interest for 9 months is " + compoundInterest[1] + " " + "and your rate is " + rate );
                        break;
                    case 2:
                        Console.WriteLine("Your interest for 12 months is " + compoundInterest[2] + " " + "and your rate is " + rate);
                        break;
                    case 3:
                        Console.WriteLine("Your interest for 24 months is " + compoundInterest[3] + " " + "and your rate is " + rate);
                        break;
                    case 4:
                        Console.WriteLine("Your interest for 60 months is " + compoundInterest[4] + " " + "and your rate is " + rate);
                        break;
                }
            } 
           
        }

        public void CurrentInterest(double[] compoundInterest, double rate)
        {
            for (int i = 0; i < compoundInterest.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        Console.WriteLine("Your interest for 6 months is " + compoundInterest[0]);
                        break;
                    case 1:
                        Console.WriteLine("Your interest for 9 months is " + compoundInterest[1]);
                        break;
                    case 2:
                        Console.WriteLine("Your interest for 12 months is " + compoundInterest[2]);
                        break;
                    case 3:
                        Console.WriteLine("Your interest for 24 months is " + compoundInterest[3]);
                        break;
                    case 4:
                        Console.WriteLine("Your interest for 60 months is " + compoundInterest[4]);
                        break;
                }
            }


           
        }
        //public double  vatRate(double rate)
        //{
        //    double rateVat = rate;
        //    rateVat = 7.5;

        //    return rateVat;

        public void KidsAccount(double[] compoundInterest, double rate)
        {
            for (int i = 0; i < compoundInterest.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Your interest for 6 months is " + compoundInterest[0]);
                        break;
                    case 1:
                        Console.WriteLine("Your interest for 9 months is " + compoundInterest[1]);
                        break;
                    case 2:
                        Console.WriteLine("Your interest for 12 months is " + compoundInterest[2]);
                        break;
                    case 3:
                        Console.WriteLine("Your interest for 24 months is " + compoundInterest[3]);
                        break;
                    case 4:
                        Console.WriteLine("Your interest for 60 months is " + compoundInterest[4]);
                        break;
                }
            }
        }



    }

        
    }

   


