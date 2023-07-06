using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal interface AnimalType
    {
        void Type();
    }
    internal class Animals:Sound,AnimalType
    {
        private string name;
        private int eyes, tail, mouth, leg;

        public Animals(string name, int eyes, int tail, int mouth, int leg)
        {
            this.Name = name;
            this.Eyes = eyes;
            this.Tail = tail;
            this.Mouth = mouth;
            this.Leg = leg;
        }

        public string Name { get => name; set => name = value; }
        public int Eyes { get => eyes; set => eyes = value; }
        public int Tail { get => tail; set => tail = value; }
        public int Mouth { get => mouth; set => mouth = value; }
        public int Leg { get => leg; set => leg = value; }

        public void Type()
        {
            if (Name == "Lion")
                Console.WriteLine("Carnivores");
            else if (Name == "Dog")
                Console.WriteLine("Omnivores");
        }
        public void MakeSound(string Name)
        {
            if (Name == "Lion")
                Console.WriteLine("Snorrrrr...");
            else if (Name == "Dog")
                Console.WriteLine("Bow Bow");
        }
    }
}
