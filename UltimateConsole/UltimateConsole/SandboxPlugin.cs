using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateConsole
{
    class SandboxPlugin
    {
        public void pluginStart()
        {
            int balance = 0;
            string rank = "none";

            string product1name = "";
            string product2name = "";
            string product3name = "";

            int product1price = 0;
            int product2price = 0;
            int product3price = 0;

            string product1company = "";
            string product2company = "";
            string product3company = "";

            int product1count = 0;
            int product2count = 0;
            int product3count = 0;

            int product1PurchasedCount = 0;
            int product2PurchasedCount = 0;
            int product3PurchasedCount = 0;
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("help - Страница с командами");
                Console.WriteLine("Введите команду(sanbox.plugin): ");
                Console.Write(">>> ");
                string from_user = Console.ReadLine();
                Console.WriteLine(" ");
                if (from_user == "help")
                {
                    Console.WriteLine("!Каждая команда пишется без пробелов в конце и другого текста!");
                    Console.WriteLine("!Вам просто нужно ввести сам текст, другие значения вы будете вводить позже!");
                    Console.WriteLine(" ");
                    Console.WriteLine("help - Страница с командами");
                    Console.WriteLine(" ");
                    Console.WriteLine("balance - Вывести текущий баланс");
                    Console.WriteLine("balance:set - Установить текущий баланс");
                    Console.WriteLine("balance:reset - Сделать ресет баланса");
                    Console.WriteLine(" ");
                    Console.WriteLine("rank - Вывести текущий ранк");
                    Console.WriteLine("rank:set - Установить текущий ранк");
                    Console.WriteLine("rank:reset - Сбросить ранк");
                    Console.WriteLine(" ");
                    Console.WriteLine("shop - Вывести все текущие товары");
                    Console.WriteLine("shop:create - Создать товар");
                    Console.WriteLine("shop:buy - Приобрести один из трёх товаров");
                    Console.WriteLine("shop:remove - Удалить один из трёх товаров");
                    Console.WriteLine(" ");
                    Console.WriteLine("inventory - Страница с приобретёнными товарами");
                }
                else if (from_user == "balance")
                {
                    Console.WriteLine("Ваш баланс: " + balance + "$");
                }
                else if (from_user == "balance:set")
                {
                    Console.Write("Введите сумму: ");
                    int balance_set = Int32.Parse(Console.ReadLine());
                    balance = balance_set;
                    Console.WriteLine("Ваш баланс успешно установлен на " + balance + "$");
                }
                else if (from_user == "balance:reset")
                {
                    balance = 0;
                    Console.WriteLine("Ваш баланс был успешно сброшен!");
                }
                else if (from_user == "rank")
                {
                    Console.WriteLine("Ваш ранк: " + rank);
                }
                else if (from_user == "rank:set")
                {
                    Console.Write("Введите ваш новый ранк: ");
                    string rank_set = Console.ReadLine();
                    rank = rank_set;
                    Console.WriteLine("Ваш ранк успешно установлен на " + rank);
                }
                else if (from_user == "rank:reset")
                {
                    rank = "";
                    Console.WriteLine("Ваш ранк успешно сброшен!");
                }
                else if (from_user == "shop")
                {
                    Console.WriteLine("Товары в ассортименте:");
                    Console.WriteLine(" ");
                    bool check = false;
                    if (product1count != 0)
                    {
                        Console.WriteLine("Товар №1 ");
                        Console.WriteLine("Имя: " + product1name);
                        Console.WriteLine("Цена: " + product1price + "$");
                        Console.WriteLine("В ассортименте: " + product1count);
                        Console.WriteLine("Компания производителя: " + product1company);
                        Console.WriteLine(" ");
                        check = true;
                    }
                    if (product2count != 0)
                    {
                        Console.WriteLine("Товар №2 ");
                        Console.WriteLine("Имя: " + product2name);
                        Console.WriteLine("Цена: " + product2price + "$");
                        Console.WriteLine("В ассортименте: " + product2count);
                        Console.WriteLine("Компания производителя: " + product2company);
                        Console.WriteLine(" ");
                        check = true;
                    }
                    if (product3count != 0)
                    {
                        Console.WriteLine("Товар №3 ");
                        Console.WriteLine("Имя: " + product3name);
                        Console.WriteLine("Цена: " + product3price + "$");
                        Console.WriteLine("В ассортименте: " + product3count);
                        Console.WriteLine("Компания производителя: " + product3company);
                        Console.WriteLine(" ");
                        check = true;
                    }
                    if (check == false)
                    {
                        Console.WriteLine("Тут пока-что ничего нет...");
                    }
                } 
                else if (from_user == "shop:create")
                {
                    Console.Write("Выберите номер товара (1, 2, 3): ");
                    string product_num = Console.ReadLine();
                    if (product_num == "1")
                    {
                        if (product1count == 0)
                        {
                            Console.Write("Введите название товара: ");
                            string product_name = Console.ReadLine();
                            product1name = product_name;

                            Console.Write("Введите стоимость товара: ");
                            int product_price = Int32.Parse(Console.ReadLine());
                            product1price = product_price;

                            Console.Write("Введите кол-во товара: ");
                            int product_count = Int32.Parse(Console.ReadLine());
                            product1count = product_count;

                            Console.Write("Введите название компании производителя: ");
                            string product_company = Console.ReadLine();
                            product1company = product_company;

                            Console.WriteLine("Вы успешно создали товар №1 " + product1name);
                        }
                        else
                        {
                            Console.WriteLine("Сначала удалите продукт для его пересоздания!");
                        }
                    }
                    else if (product_num == "2")
                    {
                        if (product2count != 0)
                        {
                            Console.Write("Введите название товара: ");
                            string product_name = Console.ReadLine();
                            product2name = product_name;

                            Console.Write("Введите стоимость товара: ");
                            int product_price = Int32.Parse(Console.ReadLine());
                            product2price = product_price;

                            Console.Write("Введите кол-во товара: ");
                            int product_count = Int32.Parse(Console.ReadLine());
                            product2count = product_count;

                            Console.Write("Введите название компании производителя: ");
                            string product_company = Console.ReadLine();
                            product2company = product_company;

                            Console.WriteLine("Вы успешно создали товар №2 " + product2name);
                        }
                        else
                        {
                            Console.WriteLine("Сначала удалите продукт для его пересоздания!");
                        }
                    }
                    else if (product_num == "3")
                    {
                        if (product3count != 0)
                        {
                            Console.Write("Введите название товара: ");
                            string product_name = Console.ReadLine();
                            product3name = product_name;

                            Console.Write("Введите стоимость товара: ");
                            int product_price = Int32.Parse(Console.ReadLine());
                            product3price = product_price;

                            Console.Write("Введите кол-во товара: ");
                            int product_count = Int32.Parse(Console.ReadLine());
                            product3count = product_count;

                            Console.Write("Введите название компании производителя: ");
                            string product_company = Console.ReadLine();
                            product3company = product_company;

                            Console.WriteLine("Вы успешно создали товар №3 " + product3name);
                        }
                        else
                        {
                            Console.WriteLine("Сначала удалите продукт для его пересоздания!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого номера товара не существует!");
                    }
                } 
                else if (from_user == "shop:remove")
                {
                    Console.WriteLine("Введите номер товара который вы хотите убрать");
                    Console.Write(">>> ");
                    string product_removenum = Console.ReadLine();
                    if (product_removenum == "1")
                    {
                        product1count = 0;
                        product1name = "";
                        Console.WriteLine("Вы успешно удалили товар №1");
                    } 
                    else if (product_removenum == "2")
                    {
                        product2count = 0;
                        product2name = "";
                        Console.WriteLine("Вы успешно удалили товар №2");
                    } 
                    else if (product_removenum == "3")
                    {
                        product3count = 0;
                        product3name = "";
                        Console.WriteLine("Вы успешно удалили товар №3");
                    }
                    else
                    {
                        Console.WriteLine("Такого номера товара не существует!");
                    }
                }
                else if (from_user == "shop:buy")
                {
                    Console.WriteLine("Введите номер товара который вы хотите приобрести");
                    Console.Write(">>> ");
                    string product_purchasenum = Console.ReadLine();
                    if (product_purchasenum == "1")
                    {
                        if (product1name != "")
                        {
                            int purchase_count = Int32.Parse(Console.ReadLine());
                            if (purchase_count > 0)
                            {
                                if (product1count >= purchase_count)
                                {
                                    if (balance >= product1price * purchase_count)
                                    {
                                        balance -= product1price * purchase_count;
                                        product1count -= purchase_count;
                                        product1PurchasedCount += purchase_count;
                                        Console.WriteLine("Вы успешно приобрели товар №1");
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас недостаточно средств!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("В магазине нет столько товара");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Количество приобретённого товара должно составлять больше 0");
                            }
                        } 
                        else
                        {
                            Console.WriteLine("Продукта не сущетсвует, либо он закончился!");
                        }
                    }
                    else if (product_purchasenum == "2")
                    {
                        if (product2name != "")
                        {
                            int purchase_count = Int32.Parse(Console.ReadLine());
                            if (purchase_count > 0)
                            {
                                if (product2count >= purchase_count)
                                {
                                    if (balance >= product2price * purchase_count)
                                    {
                                        balance -= product2price * purchase_count;
                                        product2count -= purchase_count;
                                        product2PurchasedCount += purchase_count;
                                        Console.WriteLine("Вы успешно приобрели товар №1");
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас недостаточно средств!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("В магазине нет столько товара");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Количество приобретённого товара должно составлять больше 0");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Продукта не сущетсвует, либо он закончился!");
                        }
                    }
                    else if (product_purchasenum == "3")
                    {
                        if (product3name != "")
                        {
                            int purchase_count = Int32.Parse(Console.ReadLine());
                            if (purchase_count > 0)
                            {
                                if (product3count >= purchase_count)
                                {
                                    if (balance >= product3price * purchase_count)
                                    {
                                        balance -= product3price * purchase_count;
                                        product3count -= purchase_count;
                                        product3PurchasedCount += purchase_count;
                                        Console.WriteLine("Вы успешно приобрели товар №1");
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас недостаточно средств!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("В магазине нет столько товара");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Количество приобретённого товара должно составлять больше 0");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Продукта не сущетсвует, либо он закончился!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого номера товара не существует!");
                    }
                }
                else if (from_user == "inventory")
                {
                    Console.WriteLine("Приобретённые товары:");
                    Console.WriteLine(" ");
                    bool check = false;
                    if (product1PurchasedCount > 0 && product1name != "")
                    {
                        Console.WriteLine("Товар №1");
                        Console.WriteLine("Имя: " + product1name);
                        Console.WriteLine("Приобретённого товара: " + product1PurchasedCount);
                        Console.WriteLine("Компания производителя: " + product1company);
                        Console.WriteLine(" ");
                        check = true;
                    }
                    if (product2PurchasedCount > 0 && product2name != "")
                    {
                        Console.WriteLine("Товар №2");
                        Console.WriteLine("Имя: " + product2name);
                        Console.WriteLine("Приобретённого товара: " + product2PurchasedCount);
                        Console.WriteLine("Компания производителя: " + product2company);
                        Console.WriteLine(" ");
                        check = true;
                    }
                    if (product3PurchasedCount > 0 && product3name != "")
                    {
                        Console.WriteLine("Товар №3");
                        Console.WriteLine("Имя: " + product3name);
                        Console.WriteLine("Приобретённого товара: " + product3PurchasedCount);
                        Console.WriteLine("Компания производителя: " + product3company);
                        Console.WriteLine(" ");
                        check = true;
                    }
                    if (check == false)
                    {
                        Console.WriteLine("Тут пока-что ничего нет...");
                    }
                }
                else
                {
                    Console.WriteLine("Команды не существует!");
                }
            }
        }
    }
}
