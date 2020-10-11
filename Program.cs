using Adept.OOP.Toys;
using System;

namespace Adept.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Евгений", "89854585403", 10000, 0);
            var bear1 = new Bears("Белый мишка", 1500, 25);
            var figure1 = new Figures("Статуэтка Артас", 500, 10);
            var pillow1 = new Pillows("Подушка-котик", 1000, 45);

            Action message = bear1.Display;
            message += figure1.Display;
            message += bear1.Display;
            message?.Invoke();


            Product[] items = new Product[]{
                bear1,
                figure1,
                pillow1,
                };
            


            Informer informer = new Informer();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Name}, ваш баланс: {user.Balance}");
                Console.WriteLine();
                Console.WriteLine(new String('-', 35));

                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {items[i].Name} по цене {items[i].Price}");
                }
                Console.WriteLine(new String('-', 35));
                Console.WriteLine();
                Console.Write("Выберете номер товара и нажмите Enter: ");


                int productNumber;

                while (true)
                {
                    
                    string str = Console.ReadLine();

                    if (int.TryParse(str, out int result))
                    {
                        productNumber = result;
                        break;
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Некорректный ввод. Введите целое число");
                    }


                }

                if (productNumber >= 0 && productNumber < items.Length)
                {

                    if (items[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, items[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("У вас недостаточно средств");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Таких товаров нет");
                }
            }

            Console.WriteLine("Нажмите Enter, чтобы покинуть программу");
            Console.ReadLine();
        }
    }
    
}