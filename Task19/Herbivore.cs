using System;
using System.Collections.Generic;
using System.Text;

namespace Task19
{
    class Herbivore
    {
        public event EventHandler<HerbivoreOnEatArgs> OnEat;

        public string Name { get; set; }
        public int Age { get; set; }

        public Herbivore() { }
        public Herbivore(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public void Eat(Plant p)
        {
            if(p.Size == 3)
                OnEat?.Invoke(this, 
                    new HerbivoreOnEatArgs($"{this.Name} ate plant {p.Name}"));
            else
                OnEat?.Invoke(this, 
                    new HerbivoreOnEatArgs($"{this.Name} can't eat plant {p.Name}, because it's too small"));
        }
    }
}
