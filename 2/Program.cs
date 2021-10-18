using System;
using System.Linq;
using System.Collections.Generic;

namespace TASK2
{
    class Departament
    {
        public string name;
        public string numb;
        public string bigboy;

        public Departament(string dep_name, string number, string main)
        {
            this.name = dep_name;
            this.numb = number;
            this.bigboy = main;
        }

    }

    class COworker
    {
        public string name1;
        public string name2;
        public string name3;
        public int age;
        public Departament department;

        public COworker(string surname, string firstname, string pathemic, int age, Departament department)
        {
            this.name1 = surname;
            this.name2 = firstname;
            this.name3 = pathemic;
            this.age = age;
            this.department = department;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var main_dep = new Departament("отдел по отделам", "1", "Забенько Слава");
            var prod = new Departament("производство", "2", "Логвинов Артём");
            var market = new Departament("Маркетинг", "3", "Капассовский Данил");


            var Sofia = new COworker("Гамершмидт", "Софья", "Альбертовна", 18, main_dep);
            var Artem = new COworker("Готлиб", "Артём", "Артёмович", 0, prod);
            var Jora = new COworker("Бершадский", "Георгий", "Владиславович", 228, market);
            var Lev = new COworker("Гурьянов", "Лев", "Вячеславович", 1337, prod);
            var JoraG = new COworker("Гарбуз", "Георгий", "Павлович", 17, main_dep);
            var Tanya = new COworker("Семянкова", "Татьяна", "Хайповна", 19, market);
            var CO = new List<COworker>() {  Tanya, Artem, Sofia, Jora, JoraG, Lev };

            var sort = CO.GroupBy(x => x.department.name).ToDictionary(x => x.Key, x => x.ToList());



            foreach (var i in sort)
            {
                Console.Write($"{i.Key}: ");
                foreach (var j in i.Value)
                    Console.Write($"{j.name1} ");
                Console.WriteLine();
            }
        }
    }
}