using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Завдання 2
//Створити базовий клас «Пристрій» і похідні класи: «Чайник», «Мікрохвильовка», «Автомобіль», «Пароплав».
//За допомогою конструктора, встановити назву до кожного пристрою і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук пристрою (пишемо текстом у консоль);
//■ Show — відображає назву пристрою;
//■ Desc — відображає опис пристрою.

namespace inheritance
{    class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public virtual void Sound()
        {
            Console.WriteLine("Sound of the device");
        }

        public void Show()
        {
            Console.WriteLine($"Device Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Description.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Device device)
            {
                return Name == device.Name && Description == device.Description;
            }
            return false;
        }
    }

    class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("The teapot makes noises");
        }
    }

    class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("The microwave makes noises");
        }
    }

    class Car : Device
    {
        public Car(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("The car makes noises");
        }
    }

    class Steamboat : Device
    {
        public Steamboat(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("The steamboat makes noises");
        }
    }

}
