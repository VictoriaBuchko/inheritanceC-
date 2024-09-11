using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Завдання 3(додаткове завдання)
//Створити абстрактний базовий клас «Музичний інструмент» і похідні класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». За допомогою конструктора,
//встановити назву до кожного музичного інструменту і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук музичного інструменту (пишемо текстом у консоль);
//■ Show — відображає назву музичного інструменту;
//■ Desc — відображає опис музичного інструменту;
//■ History — відображає історію створення музичного інструменту.

namespace inheritance
{
    abstract class MusicalInstrument
    {
        public string Names { get; set; }
        public string Descriptions { get; set; }
        public string Historys { get; set; }

        public MusicalInstrument(string name, string description, string history)
        {
            Names = name;
            Descriptions = description;
            Historys = history;
        }

        public abstract void Sound();

        public void Show()
        {
            Console.WriteLine($"Instrument name: {Names}");
        }

        public void SeeDescription()
        {
            Console.WriteLine($"Description: {Descriptions}");
        }
        public void History()
        {
            Console.WriteLine($"History: {Historys}");
        }
        public override int GetHashCode()
        {
            return Names.GetHashCode() ^ Descriptions.GetHashCode()^ Historys.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is MusicalInstrument instrument)
            {
                return Names == instrument.Names && Descriptions == instrument.Descriptions && Historys == instrument.Historys;
            }
            return false;
        }
    }


    class Violin : MusicalInstrument
    {
        public Violin(string name, string description, string history)
            : base(name, description, history) { }

        public override void Sound()
        {
            Console.WriteLine("The violin plays");
        }
    }

    class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description, string history)
            : base(name, description, history) { }

        public override void Sound()
        {
            Console.WriteLine("The trombone plays");
        }
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description, string history)
            : base(name, description, history) { }

        public override void Sound()
        {
            Console.WriteLine("The ukulele plays");
        }
    }

    class Cello : MusicalInstrument
    {
        public Cello(string name, string description, string history)
            : base(name, description, history) { }

        public override void Sound()
        {
            Console.WriteLine("The Cello plays");
        }
    }

}
