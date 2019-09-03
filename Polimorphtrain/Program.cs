using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphtrain
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public virtual void GetRoar()
        {
            Console.WriteLine("Battle Roar");
        }
        public virtual void GetName()
        {
            Console.WriteLine("Animal Name:"+Name);
        }
        public  virtual void GetAge()
        {
            
                Console.WriteLine("Animal age:" + Age + "year");
            
            
        } 
    }
    class Cat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Meow");
        }
    }
    class Dog : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Ouuuuuuuuuu");
        }
    }
    class Rat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Titiititititi");
        }

    }
    class Boozer : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("PshPsh");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal[] animals = new Animal[4];
            Cat cat = new Cat();
            cat.Name = "Barsik";
            cat.Age = 2;

            Dog dog = new Dog();
            dog.Name = "Tuzik";
            dog.Age = 1;
            Rat rat = new Rat();
            rat.Name = "Georgiy";
            rat.Age = 3;

            Boozer boozer = new Boozer();
            boozer.Name = "Dyadya Vitya";
            boozer.Age = 5;

            animals[0] = cat;
            animals[1] = dog;
            animals[2] = rat;
            animals[3] = boozer;
            Console.WriteLine("### MENU ###");
            Console.WriteLine("1. Cat voice");
            Console.WriteLine("2. Dog voice");
            Console.WriteLine("3. Rat voice");
            Console.WriteLine("4. Exit");
            Console.Write("Choose menu option");
            String str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    cat.GetName();
                    cat.GetAge();
                    cat.GetRoar();
                    break;
                case "2":
                    dog.GetName();
                    dog.GetAge();
                    dog.GetRoar();
                    break;

                case "3":
                    rat.GetName();
                    rat.GetAge();
                    rat.GetRoar();
                    break;
                case "4":
                    return;
                   
            }
            Console.ReadKey();
        }
    }
}
