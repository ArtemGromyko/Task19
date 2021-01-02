using System;
using System.Collections.Generic;
using System.Text;

namespace Task19
{
    class Plant
    {
        public event EventHandler<PlantOnGrowArgs> OnGrow;

        public string Name { get; set; }
        public int Size { get; private set; }

        public Plant() { }
        public Plant(string n, int s)
        {
            Name = n;
            Size = s;
        }

        public void Grow()
        {
            if (Size < 3)
            {
                Size++;
                OnGrow?.Invoke(this, new PlantOnGrowArgs("plant size increased"));
            }
            else
                OnGrow?.Invoke(this, new PlantOnGrowArgs("plant has a max size"));
        }
    }
}
