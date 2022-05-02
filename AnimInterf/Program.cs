using System;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Animal[] animals = new Animal[10];

            for (int i = 0; i < animals.Length; i++)
            {
                int index = rand.Next(0, 4);
                
                switch (index)
                {
                    case 0:
                        animals[i] = new Bat();
                        break;
                    case 1:
                        animals[i] = new Bee();
                        break;
                    case 2:
                        animals[i] = new Cat();
                        break;
                    case 3:
                        animals[i] = new Dog();
                        break;
                }

                Console.WriteLine(
                    $"Animal {i + 1} {animals[i].Sound()}");

                if (animals[i] is IMammal)
                    Console.WriteLine(
                        $"- has nipples");
                
                if (animals[i] is ICanFly)
                    Console.WriteLine(
                        $"- has wings");
            }
        }
    }
}
