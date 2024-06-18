using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateConsole
{
    class UltimateMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UltimateConsole - v1.1.0");
            Console.WriteLine(" ");
            while(true)
            {
                string from_user;
                Console.WriteLine(" ");
                Console.WriteLine("help - Страница с командами");
                Console.WriteLine("Введите команду:");
                Console.Write(">>> ");
                from_user = Console.ReadLine();
                Console.WriteLine(" ");
                if (from_user.ToLower() == "help")
                {
                    Console.WriteLine("help - Страница с командами");
                    Console.WriteLine("plugins - Страница с расширениями");
                    Console.WriteLine("update_log - Страница с логом последнего обновления");
                    Console.WriteLine("start.plugin [ИмяРасширения] - Запустить расширение");
                } 
                else if(from_user.ToLower() == "plugins")
                {
                    Console.WriteLine("sandbox - Песочница с примитивными командами");
                    Console.WriteLine("farmlands - (Расширение в разработке)");
                }
                else if(from_user.ToLower() == "start.plugin sandbox")
                {
                    var sandbox = new SandboxPlugin();
                    sandbox.pluginStart();
                } 
                else if(from_user.ToLower() == "start.plugin farmlands")
                {
                    var farmlands = new FarmlandsPlugin();
                    farmlands.farmlandsStart();
                } 
                else if(from_user.ToLower() == "update_log")
                {
                    Console.WriteLine("- Оптимизирован код расширения Sandbox");
                    Console.WriteLine("- Подключено новое расширение Farmlands");
                    Console.WriteLine("- Обновлена основная консоль");
                    Console.WriteLine("- Исправлены баги");
                }
                else
                {
                    Console.WriteLine("Команды/Плагина не существует!");
                }
            }
        }
    }
}