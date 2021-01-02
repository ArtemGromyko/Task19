using System;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Herbivore koala = new Herbivore("koala", 2);
            koala.OnEat += (sender, e) => Console.WriteLine(e.Message);

            Plant eucalyptus = new Plant("eucalyptus", 2);
            eucalyptus.OnGrow += (sender, e) => Console.WriteLine(e.Message);

            koala.Eat(eucalyptus);
            eucalyptus.Grow();
            koala.Eat(eucalyptus);

            Carnivore wolf = new Carnivore("wolf", 3);
            wolf.OnEat += (sender, e) => Console.WriteLine(e.Message);
            Herbivore rabbit = new Herbivore("rabbit", 2);

            wolf.Eat(rabbit);
        }

    }
}
