using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateConsole
{
    class FarmlandsPlugin
    {
        public void pluginStart()
        {
            int income = 0;
            int balance = 0;
            string[] fieldS1 = { "X", "X", "X", "X" };
            string[] fieldS2 = { "X", "X", "X", "X" };
            string[] fieldS3 = { "X", "X", "X", "X" };
            string[] fieldS4 = { "X", "X", "X", "X" };

            string[] fieldP1 = { "0", "0", "0", "0" };
            string[] fieldP2 = { "0", "0", "0", "0" };
            string[] fieldP3 = { "0", "0", "0", "0" };
            string[] fieldP4 = { "0", "0", "0", "0" };
            while (true)
            {
                balance += income;
                string from_user = Console.ReadLine();
                if (from_user == "help")
                {
                    Console.WriteLine("Правила игры:");
                    Console.WriteLine("В расширении Farmlands вам прийдётся строить фермы, фабрики и улучшать их");
                    Console.WriteLine("Фермы и фабрики каждый ход будут давать вам определёное кол-во денег");
                    Console.WriteLine("У вас имеется поле 4х4, на котором вы сможете выставлять свои постройки");
                    Console.WriteLine("X0 - Обозначает что клетка пустая");
                    Console.WriteLine("F0 - Обозначает что клетка занята фермой");
                    Console.WriteLine("M0 - Обозначает что клетка занята фабрикой");
                    Console.WriteLine("Цифры после букв обозначают уровень прокачки");
                    Console.WriteLine(" ");
                    Console.WriteLine("Команды:");
                    Console.WriteLine("build:FARM - Построить ферму");
                    Console.WriteLine("build:FACTORY - Построить фабрику");
                    Console.WriteLine(" ");
                    Console.WriteLine("Пример поля:");
                    Console.WriteLine("X0 F3 X0 X0");
                    Console.WriteLine("X0 F2 M1 F0");
                    Console.WriteLine("F4 M0 M0 X0");
                    Console.WriteLine("X0 X0 X0 F2");
                }
            }
        }
    }
}
