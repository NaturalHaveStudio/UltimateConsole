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
            long balance = 0;
            string rank = "none";

            string[] productnames = { "", "", "" };
            long[] productprices = { 0, 0, 0 };
            string[] productcompanies = { "", "", "" };
            long[] productcounts = { 0, 0, 0 };
            long[] productPurchasedCounts = { 0, 0, 0 };

            string transition1 = "none";
            string transition2 = "none";
            string transition3 = "none";

            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("help - Страница с командами");
                Console.WriteLine("Введите команду(sandbox.plugin): ");
                Console.Write(">>> ");
                string from_user = Console.ReadLine();
                Console.WriteLine(" ");
                if (from_user.ToLower() == "help")
                {
                    Console.WriteLine("!Каждая команда пишется без пробелов и другого текста в конце!");
                    Console.WriteLine("!Вам просто нужно ввести саму команду, другие значения вы будете вводить позже! \n");
                    Console.WriteLine("help - Страница с командами \n");
                    Console.WriteLine("balance - Вывести текущий баланс");
                    Console.WriteLine("balance:set - Установить текущий баланс");
                    Console.WriteLine("balance:reset - Сделать ресет баланса \n");
                    Console.WriteLine("rank - Вывести текущий ранк");
                    Console.WriteLine("rank:set - Установить текущий ранк");
                    Console.WriteLine("rank:reset - Сбросить ранк \n");
                    Console.WriteLine("shop - Вывести все текущие товары");
                    Console.WriteLine("shop:create - Создать товар");
                    Console.WriteLine("shop:buy - Приобрести один из трёх товаров");
                    Console.WriteLine("shop:remove - Удалить один из трёх товаров \n");
                    Console.WriteLine("transactions - Посмотреть ваши 3 последние транзакции");
                    Console.WriteLine("transactions:reset - Сбросить ваши последние транзакции \n");
                    Console.WriteLine("inventory - Страница с приобретёнными товарами");
                }
                else if (from_user.ToLower() == "balance")
                {
                    Console.WriteLine("Ваш баланс: " + balance + "$");
                }
                else if (from_user.ToLower() == "balance:set")
                {
                    Console.Write("Введите сумму: ");
                    long number;
                    bool is_balance_set = long.TryParse(Console.ReadLine(), out number);
                    if (is_balance_set)
                    {
                        balance = number;
                        Console.WriteLine("Ваш баланс успешно установлен на " + balance + "$");

                        if (transition1 == "none")
                        {
                            transition1 = "+ Ваш счёт был изменён на " + number;
                        }
                        else if (transition2 == "none")
                        {
                            transition2 = "+ Ваш счёт был изменён на " + number;
                        }
                        else if (transition3 == "none")
                        {
                            transition3 = "+ Ваш счёт был изменён на " + number;
                        }
                        else
                        {
                            transition3 = transition2;
                            transition2 = transition1;
                            transition1 = "+ Ваш счёт был изменён на " + number;
                        }
                    } else
                    {
                        Console.WriteLine("Ваше число либо содержит другие символы, либо превышает лимит 2,147,483,647");
                    }
                }
                else if (from_user.ToLower() == "balance:reset")
                {
                    if (transition1 == "none")
                    {
                        transition1 = "- Ваш баланс был сброшен";
                    }
                    else if (transition2 == "none")
                    {
                        transition2 = "- Ваш баланс был сброшен";
                    }
                    else if (transition3 == "none")
                    {
                        transition3 = "- Ваш баланс был сброшен";
                    }
                    else
                    {
                        transition3 = transition2;
                        transition2 = transition1;
                        transition1 = "- Ваш баланс был сброшен";
                    }
                    balance = 0;
                    Console.WriteLine("Ваш баланс был успешно сброшен!");
                }
                else if (from_user.ToLower() == "rank")
                {
                    Console.WriteLine("Ваш ранк: " + rank);
                }
                else if (from_user.ToLower() == "rank:set")
                {
                    Console.Write("Введите ваш новый ранк: ");
                    string rank_set = Console.ReadLine();
                    rank = rank_set;
                    Console.WriteLine("Ваш ранк успешно установлен на " + rank);
                }
                else if (from_user.ToLower() == "rank:reset")
                {
                    rank = "";
                    Console.WriteLine("Ваш ранк успешно сброшен!");
                }
                else if (from_user.ToLower() == "shop")
                {
                    Console.WriteLine("Товары в ассортименте:");
                    Console.WriteLine(" ");
                    bool check = false;
                    for (int i = 0; i < 10; i++)
                    {
                        if (productcounts[i] != 0)
                        {
                            Console.WriteLine("Товар №" + (i+1));
                            Console.WriteLine("Имя: " + productnames[i]);
                            Console.WriteLine("Цена: " + productprices[i] + "$");
                            Console.WriteLine("В ассортименте: " + productcounts[i]);
                            Console.WriteLine("Компания производителя: " + productcompanies[i]);
                            Console.WriteLine(" ");
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        Console.WriteLine("Тут пока-что ничего нет...");
                    }
                } 
                else if (from_user.ToLower() == "shop:create")
                {
                    Console.Write("Выберите номер товара (1-10): ");
                    string product_num = Console.ReadLine();
                    for (int i = 0; i < 10; i++)
                    {
                        if (product_num == $"{(i+1)}")
                        {
                            if (productcounts[i] == 0)
                            {
                                Console.Write("Введите название товара: ");
                                string product_name = Console.ReadLine();

                                Console.Write("Введите стоимость товара: ");
                                long number1;
                                bool is_product_price = long.TryParse(Console.ReadLine(), out number1);
                                if (is_product_price)
                                {
                                    long number2;
                                    Console.Write("Введите кол-во товара: ");
                                    bool is_product_count = long.TryParse(Console.ReadLine(), out number2);
                                    if (is_product_count)
                                    {
                                        Console.Write("Введите название компании производителя: ");
                                        string product_company = Console.ReadLine();

                                        productnames[i] = product_name;
                                        productprices[i] = number1;
                                        productcounts[i] = number2;
                                        productcompanies[i] = product_company;

                                        Console.WriteLine("Вы успешно создали товар №" + (i + 1) + " " + productnames[i]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ваше число либо содержит другие символы, либо превышает лимит 2,147,483,647");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ваше число либо содержит другие символы, либо превышает лимит 2,147,483,647");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Сначала удалите продукт для его пересоздания!");
                            }
                        }
                    }
                } 
                else if (from_user.ToLower() == "shop:remove")
                {
                    Console.WriteLine("Введите номер товара который вы хотите убрать");
                    Console.Write(">>> ");
                    bool created = false;
                    string product_removenum = Console.ReadLine();
                    for (int i = 0; i < 10; i++)
                    {
                        if (product_removenum == $"{(i+1)}")
                        {
                            if (transition1 == "none")
                            {
                                transition1 = "+" + productprices[i] * productPurchasedCounts[i] + "$ прибавлено к вашему счёту за удалённый товар";
                            }
                            else if (transition2 == "none")
                            {
                                transition2 = "+" + productprices[i] * productPurchasedCounts[i] + "$ прибавлено к вашему счёту за удалённый товар";
                            }
                            else if (transition3 == "none")
                            {
                                transition3 = "+" + productprices[i] * productPurchasedCounts[i] + "$ прибавлено к вашему счёту за удалённый товар";
                            }
                            else
                            {
                                transition3 = transition2;
                                transition2 = transition1;
                                transition1 = "+" + productprices[i] * productPurchasedCounts[i] + "$ прибавлено к вашему счёту за удалённый товар";
                            }
                            created = true;

                            productcounts[i] = 0;
                            balance += productprices[i] * productPurchasedCounts[i];
                            productnames[i] = "";
                            Console.WriteLine("Вы успешно удалили товар №" + (i+1));
                        }
                    } 
                    if (created == false)
                    {
                        Console.WriteLine("Такого номера товара не существует!");
                    }
                }
                else if (from_user.ToLower() == "shop:buy")
                {
                    Console.WriteLine("Введите номер товара который вы хотите приобрести");
                    Console.Write(">>> ");
                    string product_purchasenum = Console.ReadLine();
                    bool purchased = false;
                    for (int i = 0; i < 10; i++)
                    {
                        if (product_purchasenum == $"{(i+1)}")
                        {
                            purchased = true;
                            if (productnames[i] != "")
                            {
                                Console.WriteLine("Выберите количество товара для приобретения ");
                                long purchase_count = long.Parse(Console.ReadLine());
                                if (purchase_count > 0)
                                {
                                    if (productcounts[i] >= purchase_count)
                                    {
                                        if (balance >= productprices[i] * purchase_count)
                                        {
                                            if (transition1 == "none")
                                            {
                                                transition1 = "-" + productprices[i] * productPurchasedCounts[i] + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + productnames[i];
                                            }
                                            else if (transition2 == "none")
                                            {
                                                transition2 = "-" + productprices[i] * productPurchasedCounts[i] + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + productnames[i];
                                            }
                                            else if (transition3 == "none")
                                            {
                                                transition3 = "-" + productprices[i] * productPurchasedCounts[i] + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + productnames[i];
                                            }
                                            else
                                            {
                                                transition3 = transition2;
                                                transition2 = transition1;
                                                transition1 = "-" + productprices[i] * productPurchasedCounts[i] + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + productnames[i];
                                            }

                                            balance -= productprices[i] * purchase_count;
                                            productcounts[i] -= purchase_count;
                                            productPurchasedCounts[i] += purchase_count;
                                            Console.WriteLine("Вы успешно приобрели товар №" + (i+1));
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
                    }
                    if (purchased == false)
                    {
                        Console.WriteLine("Такого номера товара не существует!");
                    }
                }
                else if (from_user.ToLower() == "inventory")
                {
                    Console.WriteLine("Приобретённые товары:");
                    Console.WriteLine(" ");
                    bool check = false;
                    for (int i = 0; i < 10; i++)
                    {
                        if (productPurchasedCounts[i] > 0 && productnames[i] != "")
                        {
                            Console.WriteLine("Товар №" + (i+1));
                            Console.WriteLine("Имя: " + productnames[i]);
                            Console.WriteLine("Приобретённого товара: " + productPurchasedCounts[i]);
                            Console.WriteLine("Компания производителя: " + productcompanies[i]);
                            Console.WriteLine(" ");
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        Console.WriteLine("Тут пока-что ничего нет...");
                    }
                }
                else if (from_user.ToLower() == "transactions")
                {
                    Console.WriteLine("3 последних транзакции:");
                    bool check = false;
                    if (transition1 != "none")
                    {
                        Console.WriteLine(transition1);
                        check = true;
                    }
                    if (transition2 != "none")
                    {
                        Console.WriteLine(transition2);
                        check = true;
                    }
                    if (transition3 != "none")
                    {
                        Console.WriteLine(transition3);
                        check = true;
                    }
                    if (check == false)
                    {
                        Console.WriteLine("Тут пока-что ничего нет...");
                    }
                }
                else if (from_user.ToLower() == "transactions:reset")
                {
                    transition1 = "none";
                    transition2 = "none";
                    transition3 = "none";
                    Console.WriteLine("Транзакции были успешно сброшены!");
                }
                else
                {
                    Console.WriteLine("Команды не существует!");
                }
            }
        }
    }
}