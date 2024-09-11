namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 1");
            Console.ResetColor();

            Product product = new Product("Тістечко", 5, 50);
            Console.WriteLine(product.ToString());
            product.Discount(1, 75);
            Console.WriteLine(product.ToString());

            Product prod1 = new Product("Яблуко", 1000, 50);
            Product prod2 = new Product("Груша", 500, 75);


            Console.WriteLine("Is product 1 more similar to product 2?");
            Console.WriteLine(prod1.Equals(prod2));
            Console.WriteLine();

            //----------------------------------------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 2");
            Console.ResetColor();
   
            Device kettle = new Kettle("Kettle", "boiling water");
            Device microwave = new Microwave("Microwave", "heating food");
            Device car = new Car("Car", "is designed to be ridden");
            Device steamboat = new Steamboat("Steamboat", "designed for swimming ");
            Device device1 = new Kettle("Electric Kettle", "Boils water quickly");
            Device device2 = new Kettle("Electric Kettle", "Boils water quickly");


            Device[] devices = { kettle, microwave, car, steamboat };

            foreach (Device device in devices)
            {
                device.Show();
                device.Desc();
                device.Sound();
                Console.WriteLine($"HashCode: {device.GetHashCode()}");
                Console.WriteLine();
            }
            

            Device kettle1 = new Kettle("Electric kettle", "boils water quickly");
            Device kettle2 = new Kettle("Electric kettle", "boils water quickly");

            Console.WriteLine("Is device 1 more similar to device 2?");
            if (device1.Equals(device2))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            Console.WriteLine();

            //----------------------------------------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 3");
            Console.ResetColor();

            MusicalInstrument violin = new Violin("Violin", "bowed string instrument with four strings", "the violin's birthplace is India");
            MusicalInstrument trombone = new Trombone("Trombone", "a movable rocker that smoothly changes the volume of air in the instrument and, consequently, the pitch of the sound", "developed in the 15th century.");
            MusicalInstrument ukulele = new Ukulele("Ukulele", "A small, four-stringed instrument", "Originated in Hawaii in the 19th century.");
            MusicalInstrument cello = new Cello("Cello", "a bowed string instrument of the bass and tenor registers,", "Originated in the 16th century");

            MusicalInstrument[] instruments = { violin, trombone, ukulele, cello };

            foreach (MusicalInstrument instrument in instruments)
            {
                instrument.Show();
                instrument.Sound();
                instrument.SeeDescription();              
                instrument.History();
                Console.WriteLine($"Instrument: {instrument.GetHashCode()}");
                Console.WriteLine();
            }

            Console.WriteLine("Is instrument 1 more similar to instrument 2?");
            if (violin.Equals(cello))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            Console.WriteLine();
            //----------------------------------------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 4");
            Console.ResetColor();

            Animal[] zoo = new Animal[]
        {
            new Tiger("Tiger1", 200, true, "Bold"),
            new Crocodile("Crocodile1", 300, true, 4.5),
            new Kangaroo("Kangaroo1", 70, false, 15)
        };

            foreach (var animal in zoo)
            {
                Console.WriteLine(animal.ToString());
                Console.WriteLine($"HashCode: {animal.GetHashCode()}");
            }
            Console.WriteLine();

            int predatorsCount = 0;
            double totalMeatFood = 0;
            double totalPlantFood = 0;

            foreach (var animal in zoo)
            {
                if (animal.IsPredator)
                {
                    predatorsCount++;
                    totalMeatFood += animal.CalculateFoodRequirement();
                }
                else
                {
                    totalPlantFood += animal.CalculateFoodRequirement();
                }
            }

            Console.WriteLine($"The number of predators in the zoo: {predatorsCount}");
            Console.WriteLine($"The amount of food for predators: {totalMeatFood:F2} кг");
            Console.WriteLine($"Amount of plant food for herbivores: {totalPlantFood:F2} кг");

        }
    }
}
