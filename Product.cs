using System;

namespace Adept.OOP
{
        abstract class Product : IProduct
    {
        public string Name { get; }
        public double Price { get; }
        public int Size { get; }

        public Product (string name, double price, int size)
        {
            if (string.IsNullOrWhiteSpace(nameof(name)))
            {
                throw new ArgumentNullException();
            }

            if (price < 0)
            {
                throw new ArgumentException();
            }

            if (size <= 0)
            {
                throw new ArgumentException();
            }
                
            Name = name;
            Price = price;
            Size = size;
        }

        public double GetDiscountPrice (User user)
        {
            if (user.Spent < 2000)
            {
                return Price;
            }

            if (user.Spent < 5000)
            {
                return Price * 0.9;
            }

            return Price * 0.8;
        }


        public void Display()
        {
            Console.WriteLine("Игрушка:");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Размер в сантиметрах: " + Size);
            Console.WriteLine(new String('-', 25));
        }
    }
}
