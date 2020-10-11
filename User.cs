using System;

namespace Adept.OOP
{
    internal class User
    {
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }

        public User (string name, string phone, double balance, double spent)
        {
            Name = name;
            Phone = phone;
            Balance = balance;
            Spent = spent;
        }

        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }

    }
}
