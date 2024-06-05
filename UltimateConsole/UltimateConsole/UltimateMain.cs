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
            while(true)
            {
                string from_user;
                Console.WriteLine("help - Страница с командами");
                Console.WriteLine("Введите команду:");
                Console.Write(">>> ");
                from_user = Console.ReadLine();

                if(from_user == "help")
                {
                    Console.WriteLine("help - Страница с командами");
                    Console.WriteLine("plugins - Страница с расширениями");
                    Console.WriteLine("start.plugin [ИмяРасширения] - Запустить расширение");
                } else if(from_user == "plugins")
                {
                    Console.WriteLine("sandbox - Песочница с примитивными командами");
                    Console.WriteLine("farmlands - (Расширение в разработке)");
                } else if(from_user == "start.plugin sandbox")
                {
                    var sandbox = new SandboxPlugin();
                    sandbox.pluginStart();
                } else
                {
                    Console.WriteLine("Команды/Плагина не существует!");
                }
            }
        }
    }
}
