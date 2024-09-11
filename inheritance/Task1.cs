using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 1
//Запрограмуйте клас Money (об'єкт класу оперує однією валютою) для роботи з грошима.
//У класі мають бути передбачені: поле для зберігання цілої частини грошей (долари, євро, гривні тощо) і поле
//для зберігання копійок (центи, євроценти, копійки тощо)
//Реалізувати методи виведення суми на екран, задання значень частин.
//На базі класу Money створити клас Product для роботи з продуктом або товаром. Реалізувати метод, який дозволяє зменшити ціну на задане число.
//Для кожного з класів реалізувати необхідні методи і поля.
namespace inheritance
{
    
    class Money
    {
        protected int Currency = 0;
        protected int Cents = 0;

        public Money(int currency, int cents)
        {
            Currency = currency;
            Cents = cents;

            if (Cents >= 100)
            {
                Currency += Cents / 100;
                Cents = Cents % 100;
            }

        }

        public override string ToString()
        {
            return $"Кількість грошей: {Currency}.{Cents:D2}";
        }

        public void SetValues(int currency, int cents)
        {
            Currency = currency;
            Cents = cents;

            if (Cents >= 100)
            {
                Currency += Cents / 100;
                Cents = Cents % 100;
            }

        }

        public void Decrease(int currency, int cents)
        {
            int sum = Currency * 100 + Cents;//переведення в копійки поточної суми 
            int decrease = currency * 100 + cents;//переведення в копійки суми для віднімання 

            if (sum >= decrease)
            {
                sum -= decrease;
                Currency = sum / 100;
                Cents = sum % 100;
            }
            else
            {
                Console.WriteLine("Сума не може бути менше 0");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Money money)
            {
                return Currency == money.Currency && Cents == money.Cents;
            }
            return false;
        }
    }

    class Product : Money
    {
        private string Name;


        public Product(string name, int currency, int cents) : base(currency, cents)
        {
            Name = name;
        }

        public void Discount(int currency, int cents)
        {
            Console.WriteLine($"Продукт: {Name}, Ціна: {currency}.{cents:D2}");
            Console.WriteLine($"{Currency}.{Cents:D2} - {currency}.{cents:D2}");
            Decrease(currency, cents);
        }

        public override string ToString()
        {
            return $"Продукт: {Name}, Загальна ціна: {Currency}.{Cents:D2}";
        }
    }
}
