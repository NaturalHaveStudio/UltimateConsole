using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateConsole
{
    class FarmlandsPlugin
    {
        public void farmlandsStart()
        {
            int income = 0;
            int balance = 100;
            string[] fieldS1 = { "X", "X", "X", "X" };
            string[] fieldS2 = { "X", "X", "X", "X" };
            string[] fieldS3 = { "X", "X", "X", "X" };
            string[] fieldS4 = { "X", "X", "X", "X" };

            int[] fieldP1 = { 0, 0, 0, 0 };
            int[] fieldP2 = { 0, 0, 0, 0 };
            int[] fieldP3 = { 0, 0, 0, 0 };
            int[] fieldP4 = { 0, 0, 0, 0 };
            while (true)
            {
                balance += income;
                Console.WriteLine(" ");
                if (income > 0 )
                {
                    Console.WriteLine("+" + income + "$ доход");
                }
                Console.WriteLine("Ваш текущий баланс: " + balance + "$");
                Console.WriteLine("help - Страница с командами");
                Console.WriteLine("Введите команду(farmlands.plugin): ");
                Console.Write(">>> ");
                string from_user = Console.ReadLine();
                Console.WriteLine(" ");
                if (from_user.ToLower() == "help")
                {
                    Console.WriteLine("Правила игры:");
                    Console.WriteLine("В расширении Farmlands вам прийдётся строить фермы, фабрики и улучшать их");
                    Console.WriteLine("Фермы и фабрики каждый ход будут давать вам определёное кол-во денег");
                    Console.WriteLine("У вас имеется поле 4х4, на котором вы сможете выставлять свои постройки");
                    Console.WriteLine("Ферма - даёт 10$ в ход, имеет 5 прокачек, стоимость - 75$ за постройку, 20$ за прокачку и +5$ за ход");
                    Console.WriteLine("Фабрика - даёт 50$ в ход, имеет 3 прокачки, стоимость - 250$ за постройку, 50$ за прокачку и +25$ за ход");
                    Console.WriteLine("X0 - Обозначает что клетка пустая");
                    Console.WriteLine("F0 - Обозначает что клетка занята фермой");
                    Console.WriteLine("M0 - Обозначает что клетка занята фабрикой");
                    Console.WriteLine("Цифры после букв обозначают уровень прокачки");

                    Console.WriteLine(" ");

                    Console.WriteLine("Команды:");
                    Console.WriteLine("build:farm - Построить ферму");
                    Console.WriteLine("build:factory - Построить фабрику");
                    Console.WriteLine("build:remove - Удалить постройку");

                    Console.WriteLine("upgrade:farm - Построить ферму");
                    Console.WriteLine("upgrade:factory - Построить фабрику");

                    Console.WriteLine("field - Вывести поле");
                    Console.WriteLine("skip - Пропустить ход");

                    Console.WriteLine(" ");

                    Console.WriteLine("Пример поля:");
                    Console.WriteLine("X0 F3 X0 X0");
                    Console.WriteLine("X0 F2 M1 F0");
                    Console.WriteLine("F4 M0 M0 X0");
                    Console.WriteLine("X0 X0 X0 F2");

                    Console.WriteLine(" ");

                    Console.WriteLine("Ваш текущий баланс: " + balance + "$");
                }
                else if (from_user.ToLower() == "skip")
                {
                    Console.WriteLine("Вы пропустили ход!");
                }
                else if (from_user.ToLower() == "field")
                {
                    Console.WriteLine(fieldS1[0] + "" + fieldP1[0] + " " + fieldS1[1] + "" + fieldP1[1] + " " + fieldS1[2] + "" + fieldP1[2] + " " + fieldS1[3] + "" + fieldP1[3] + " ");
                    Console.WriteLine(fieldS2[0] + "" + fieldP2[0] + " " + fieldS2[1] + "" + fieldP2[1] + " " + fieldS2[2] + "" + fieldP2[2] + " " + fieldS2[3] + "" + fieldP2[3] + " ");
                    Console.WriteLine(fieldS3[0] + "" + fieldP3[0] + " " + fieldS3[1] + "" + fieldP3[1] + " " + fieldS3[2] + "" + fieldP3[2] + " " + fieldS3[3] + "" + fieldP3[3] + " ");
                    Console.WriteLine(fieldS4[0] + "" + fieldP4[0] + " " + fieldS4[1] + "" + fieldP4[1] + " " + fieldS4[2] + "" + fieldP4[2] + " " + fieldS4[3] + "" + fieldP4[3] + " ");
                }
                else if (from_user.ToLower() == "build:farm")
                {
                    Console.WriteLine("Ваш баланс: " + balance + "$");
                    if (balance >= 75)
                    {
                        Console.WriteLine("Введите номер строки(1-4): ");
                        int number;
                        bool is_num = Int32.TryParse(Console.ReadLine(), out number);
                        if (is_num)
                        {
                            if (number == 1)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS1[number2] == "X")
                                    {
                                        fieldS1[number2] = "F";
                                        balance -= 75;
                                        income += 10;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 2)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS2[number2] == "X")
                                    {
                                        fieldS2[number2] = "F";
                                        balance -= 75;
                                        income += 10;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 3)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS3[number2] == "X")
                                    {
                                        fieldS3[number2] = "F";
                                        balance -= 75;
                                        income += 10;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 4)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS4[number2] == "X")
                                    {
                                        fieldS4[number2] = "F";
                                        balance -= 75;
                                        income += 10;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                        }
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств!");
                    }
                }
                else if (from_user.ToLower() == "build:factory")
                {
                    Console.WriteLine("Ваш баланс: " + balance + "$");
                    if (balance >= 250)
                    {
                        Console.WriteLine("Введите номер строки(1-4): ");
                        int number;
                        bool is_num = Int32.TryParse(Console.ReadLine(), out number);
                        if (is_num)
                        {
                            if (number == 1)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS1[number2] == "X")
                                    {
                                        fieldS1[number2] = "M";
                                        balance -= 250;
                                        income += 50;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 2)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS2[number2] == "X")
                                    {
                                        fieldS2[number2] = "M";
                                        balance -= 250;
                                        income += 50;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка уже занята!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 3)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS3[number2] == "X")
                                    {
                                        fieldS3[number2] = "M";
                                        balance -= 250;
                                        income += 50;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка уже занята!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 4)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS4[number2] == "X")
                                    {
                                        fieldS4[number2] = "M";
                                        balance -= 250;
                                        income += 50;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка уже занята!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                        }
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств!");
                    }
                }
                else if (from_user.ToLower() == "upgrade:farm")
                {
                    Console.WriteLine("Ваш баланс: " + balance + "$");
                    if (balance >= 50)
                    {
                        Console.WriteLine("Введите номер строки(1-4): ");
                        int number;
                        bool is_num = Int32.TryParse(Console.ReadLine(), out number);
                        if (is_num)
                        {
                            if (number == 1)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS1[number2] == "F")
                                    {
                                        if (fieldP1[number2] < 5)
                                        {
                                            fieldP1[number2] += 1;
                                            income += 5;
                                            balance -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Уровень вашей фермы уже максимальный!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка пуста, либо занята фабрикой!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 2)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS2[number2] == "F")
                                    {
                                        if (fieldP2[number2] < 5)
                                        {
                                            fieldP2[number2] += 1;
                                            income += 5;
                                            balance -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Уровень вашей фермы уже максимальный!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка пуста, либо занята фабрикой!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 3)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS3[number2] == "F")
                                    {
                                        if (fieldP3[number2] < 5)
                                        {
                                            fieldP3[number2] += 1;
                                            income += 5;
                                            balance -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Уровень вашей фермы уже максимальный!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка пуста, либо занята фабрикой!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 4)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS4[number2] == "F")
                                    {
                                        if (fieldP4[number2] < 5)
                                        {
                                            fieldP4[number2] += 1;
                                            income += 5;
                                            balance -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Уровень вашей фермы уже максимальный!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка пуста, либо занята фабрикой!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                        }
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств!");
                    }
                }
                else if (from_user.ToLower() == "upgrade:factory")
                {
                    Console.WriteLine("Ваш баланс: " + balance + "$");
                    if (balance >= 50)
                    {
                        Console.WriteLine("Введите номер строки(1-4): ");
                        int number;
                        bool is_num = Int32.TryParse(Console.ReadLine(), out number);
                        if (is_num)
                        {
                            if (number == 1)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS1[number2] == "M")
                                    {
                                        if (fieldP1[number2] < 5)
                                        {
                                            fieldP1[number2] += 1;
                                            income += 25;
                                            balance -= 50;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Уровень вашей фабрики уже максимальный!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка пуста, либо занята фермой!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 2)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS2[number2] == "M")
                                    {
                                        if (fieldP2[number2] < 3)
                                        {
                                            fieldP2[number2] += 1;
                                            income += 25;
                                            balance -= 50;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Уровень вашей фабрики уже максимальный!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка пуста, либо занята фермой!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 3)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS3[number2] == "M")
                                    {
                                        if (fieldP3[number2] < 3)
                                        {
                                            fieldP3[number2] += 1;
                                            income += 25;
                                            balance -= 50;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Уровень вашей фабрики уже максимальный!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка пуста, либо занята фермой!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else if (number == 4)
                            {
                                Console.WriteLine("Введите номер столбца(1-4): ");
                                int number2;
                                bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_num2 && number2 < 5 && number2 > 0)
                                {
                                    if (fieldS4[number2] == "M")
                                    {
                                        if (fieldP4[number2] < 3)
                                        {
                                            fieldP4[number2] += 1;
                                            income += 25;
                                            balance -= 50;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Уровень вашей фабрики уже максимальный!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Выбранная вами клетка пуста, либо занята фермой!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ваш номер не является 1, 2, 3 или 4");
                        }
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств!");
                    }
                }
                else if (from_user.ToLower() == "build:remove")
                {
                    Console.WriteLine("Введите номер строки(1-4): ");
                    int number;
                    bool is_num = Int32.TryParse(Console.ReadLine(), out number);
                    if (is_num)
                    {
                        if (number == 1)
                        {
                            Console.WriteLine("Введите номер столбца(1-4): ");
                            int number2;
                            bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                            if (is_num2 && number2 < 5 && number2 > 0)
                            {
                                if (fieldS1[number2] == "M")
                                {
                                    fieldS1[number2] = "X";
                                    fieldP1[number2] = 0;
                                    income -= 50 + (fieldP1[number2] * 25);
                                    Console.WriteLine("Вы успешно удалили вашу фабрику!");
                                }
                                else if (fieldS1[number2] == "F")
                                {
                                    fieldS1[number2] = "X";
                                    fieldP1[number2] = 0;
                                    income -= 10 + (fieldP1[number2] * 5);
                                    Console.WriteLine("Вы успешно удалили вашу ферму!");
                                }
                                else
                                {
                                    Console.WriteLine("Выбраная вами клетка уже пустая!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ваш номер не является 1, 2, 3, 4");
                            }
                        }
                        else if (number == 2)
                        {
                            Console.WriteLine("Введите номер столбца(1-4): ");
                            int number2;
                            bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                            if (is_num2 && number2 < 5 && number2 > 0)
                            {
                                if (fieldS2[number2] == "M")
                                {
                                    fieldS2[number2] = "X";
                                    fieldP2[number2] = 0;
                                    income -= 50 + (fieldP2[number2] * 25);
                                    Console.WriteLine("Вы успешно удалили вашу фабрику!");
                                }
                                else if (fieldS2[number2] == "F")
                                {
                                    fieldS2[number2] = "X";
                                    fieldP2[number2] = 0;
                                    income -= 10 + (fieldP2[number2] * 5);
                                    Console.WriteLine("Вы успешно удалили вашу ферму!");
                                }
                                else
                                {
                                    Console.WriteLine("Выбраная вами клетка уже пустая!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ваш номер не является 1, 2, 3, 4");
                            }
                        }
                        else if (number == 3)
                        {
                            Console.WriteLine("Введите номер столбца(1-4): ");
                            int number2;
                            bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                            if (is_num2 && number2 < 5 && number2 > 0)
                            {
                                if (fieldS3[number2] == "M")
                                {
                                    fieldS3[number2] = "X";
                                    fieldP3[number2] = 0;
                                    income -= 50 + (fieldP3[number2] * 25);
                                    Console.WriteLine("Вы успешно удалили вашу фабрику!");
                                }
                                else if (fieldS3[number2] == "F")
                                {
                                    fieldS3[number2] = "X";
                                    fieldP3[number2] = 0;
                                    income -= 10 + (fieldP3[number2] * 5);
                                    Console.WriteLine("Вы успешно удалили вашу ферму!");
                                }
                                else
                                {
                                    Console.WriteLine("Выбраная вами клетка уже пустая!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ваш номер не является 1, 2, 3, 4");
                            }
                        }
                        else if (number == 4)
                        {
                            Console.WriteLine("Введите номер столбца(1-4): ");
                            int number2;
                            bool is_num2 = Int32.TryParse(Console.ReadLine(), out number2);
                            if (is_num2 && number2 < 5 && number2 > 0)
                            {
                                if (fieldS4[number2] == "M")
                                {
                                    fieldS4[number2] = "X";
                                    fieldP4[number2] = 0;
                                    income -= 50 + (fieldP4[number2] * 25);
                                    Console.WriteLine("Вы успешно удалили вашу фабрику!");
                                }
                                else if (fieldS4[number2] == "F")
                                {
                                    fieldS4[number2] = "X";
                                    fieldP4[number2] = 0;
                                    income -= 10 + (fieldP4[number2] * 5);
                                    Console.WriteLine("Вы успешно удалили вашу ферму!");
                                }
                                else
                                {
                                    Console.WriteLine("Выбраная вами клетка уже пустая!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ваш номер не является 1, 2, 3, 4");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ваш номер не является 1, 2, 3, 4");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ваш номер не является 1, 2, 3, 4");
                    }
                }
            }
        }
    }
}