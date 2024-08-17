using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class PaymentCard
    {
        private double balance;
        public PaymentCard(double openingBalance)
        {
            balance += openingBalance; 

        }
        public override string ToString()
        {
            return $"The card has a balance of {balance} euros \n\n";
        }

        public void DrinkCoffee()
        {
            double drink = 2.0;
            if (balance >= drink)
            {
                balance -= drink;
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }

        public void EatLunch()
        {
            double Eat = 10.60;
            if (balance >= Eat)
            {
                balance -= Eat;
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }

        public void AddMoney(double amount)
        {

            if (amount >= 150)
            {

                Console.WriteLine("You can't exceed 150");

            }
            else if (amount <= 0)
            {
                Console.WriteLine("You can't add negative amount");

            }
            else
            {
                balance += amount;
            }






            }
        }
}
