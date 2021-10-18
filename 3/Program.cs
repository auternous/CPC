using System;

namespace TASK3
{
    interface ANIM
    {
        void WHATITTALK();
    }

    class Cat : ANIM
    {
        public string Name;
        public Cat(string Name)
        {
            this.Name = Name;
        }
        public void WHATITTALK()
        {
            Console.WriteLine("МЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯЯУУУУУУУУУУУУУУУУУ");
        }
    }
    class Parot : ANIM
    {
        public void WHATITTALK()
        {
            Console.WriteLine("ААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААА");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ANIM Creatures = new Cat("Астра");
            Creatures.WHATITTALK();
            Creatures = new Parot();
            Creatures.WHATITTALK();
        }
    }
}