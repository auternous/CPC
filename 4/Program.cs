using System;

namespace Task4
{
    class Peregruz
    {
        public double Voice(double a1, double a2)
        {
            return a1*a2;
        }
        public int Voice(int a1, int a2, int a3)
        {
            return a1 * a2 * a3;
        }
    }
    class COworkers
    {
        public string name1;
        public string name2;
        public int age;

        public COworkers(string name, int AGE)
        {
            this.name1 = name;
            this.age = AGE;
        }
        public COworkers(string name, string sername, int AGE)
        {
            this.name1 = name;
            this.name2 = sername;
            this.age = AGE;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var itog = new Peregruz();
            Console.WriteLine(itog.Voice(8.3, 2.5));
            Console.WriteLine(itog.Voice(12, 33, 10));

            var w1 = new COworkers("Артём", 18);
            var w2 = new COworkers("Георгий", "Гарбуз", 988);
        }
    }
}