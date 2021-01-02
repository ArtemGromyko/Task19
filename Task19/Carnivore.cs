using System;
using System.Collections.Generic;
using System.Text;

namespace Task19
{
    class Carnivore
    {
        public event EventHandler<CarnivoreOnEatArgs> OnEat;

        public string Name { get; set; }
        public int Age { get; set; }

        public Carnivore() { }
        public Carnivore(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public void Eat(Herbivore h)
        {
            OnEat?.Invoke(this, new CarnivoreOnEatArgs($"{this.Name} ate {h.Name}"));
        }
    }
}
