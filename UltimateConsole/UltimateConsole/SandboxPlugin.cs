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

            string transition1 = "none";
            string transition2 = "none";
            string transition3 = "none";

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
                    Console.WriteLine("!Каждая команда пишется без пробелов и другого текста в конце!");
                    Console.WriteLine("!Вам просто нужно ввести саму команду, другие значения вы будете вводить позже!");
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
                    Console.WriteLine("transactions - Посмотреть ваши 3 последние транзакции");
                    Console.WriteLine("transactions:reset - Сбросить ваши последние транзакции");
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
                    int number;
                    bool is_balance_set = Int32.TryParse(Console.ReadLine(), out number);
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
                else if (from_user == "balance:reset")
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

                            Console.Write("Введите стоимость товара: ");
                            int number1;
                            bool is_product_price = Int32.TryParse(Console.ReadLine(), out number1);
                            if (is_product_price)
                            {
                                int number2;
                                Console.Write("Введите кол-во товара: ");
                                bool is_product_count = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_product_count)
                                {
                                    Console.Write("Введите название компании производителя: ");
                                    string product_company = Console.ReadLine();

                                    product1name = product_name;
                                    product1price = number1;
                                    product1count = number2;
                                    product1company = product_company;

                                    Console.WriteLine("Вы успешно создали товар №1 " + product1name);
                                }
                                else
                                {
                                    Console.WriteLine("Ваше число либо содержит другие символы, либо превышает лимит 2,147,483,647");
                                }
                            } else
                            {
                                Console.WriteLine("Ваше число либо содержит другие символы, либо превышает лимит 2,147,483,647");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Сначала удалите продукт для его пересоздания!");
                        }
                    }
                    else if (product_num == "2")
                    {
                        if (product2count == 0)
                        {
                            Console.Write("Введите название товара: ");
                            string product_name = Console.ReadLine();

                            Console.Write("Введите стоимость товара: ");
                            int number1;
                            bool is_product_price = Int32.TryParse(Console.ReadLine(), out number1);
                            if (is_product_price)
                            {
                                int number2;
                                Console.Write("Введите кол-во товара: ");
                                bool is_product_count = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_product_count)
                                {
                                    Console.Write("Введите название компании производителя: ");
                                    string product_company = Console.ReadLine();

                                    product2name = product_name;
                                    product2price = number1;
                                    product2count = number2;
                                    product2company = product_company;

                                    Console.WriteLine("Вы успешно создали товар №1 " + product2name);
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
                    else if (product_num == "3")
                    {
                        if (product3count == 0)
                        {
                            Console.Write("Введите название товара: ");
                            string product_name = Console.ReadLine();

                            Console.Write("Введите стоимость товара: ");
                            int number1;
                            bool is_product_price = Int32.TryParse(Console.ReadLine(), out number1);
                            if (is_product_price)
                            {
                                int number2;
                                Console.Write("Введите кол-во товара: ");
                                bool is_product_count = Int32.TryParse(Console.ReadLine(), out number2);
                                if (is_product_count)
                                {
                                    Console.Write("Введите название компании производителя: ");
                                    string product_company = Console.ReadLine();

                                    product3name = product_name;
                                    product3price = number1;
                                    product3count = number2;
                                    product3company = product_company;

                                    Console.WriteLine("Вы успешно создали товар №1 " + product3name);
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
                        if (transition1 == "none")
                        {
                            transition1 = "+" + product1price * product1PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        } else if (transition2 == "none")
                        {
                            transition2 = "+" + product1price * product1PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        } else if (transition3 == "none")
                        {
                            transition3 = "+" + product1price * product1PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        } else
                        {
                            transition3 = transition2;
                            transition2 = transition1;
                            transition1 = "+" + product1price * product1PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        }


                        product1count = 0;
                        balance += product1price*product1PurchasedCount;
                        product1name = "";
                        Console.WriteLine("Вы успешно удалили товар №1");
                    } 
                    else if (product_removenum == "2")
                    {
                        if (transition1 == "none")
                        {
                            transition1 = "+" + product2price * product2PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        }
                        else if (transition2 == "none")
                        {
                            transition2 = "+" + product2price * product2PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        }
                        else if (transition3 == "none")
                        {
                            transition3 = "+" + product2price * product2PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        }
                        else
                        {
                            transition3 = transition2;
                            transition2 = transition1;
                            transition1 = "+" + product2price * product2PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        }

                        product2count = 0;
                        balance += product2price * product2PurchasedCount;
                        product2name = "";
                        Console.WriteLine("Вы успешно удалили товар №2");
                    } 
                    else if (product_removenum == "3")
                    {
                        if (transition1 == "none")
                        {
                            transition1 = "+" + product3price * product3PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        }
                        else if (transition2 == "none")
                        {
                            transition2 = "+" + product3price * product3PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        }
                        else if (transition3 == "none")
                        {
                            transition3 = "+" + product3price * product3PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        }
                        else
                        {
                            transition3 = transition2;
                            transition2 = transition1;
                            transition1 = "+" + product3price * product3PurchasedCount + "$ прибавлено к вашему счёту за удалённый товар";
                        }

                        product3count = 0;
                        balance += product3price * product3PurchasedCount;
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
                            Console.WriteLine("Выберите количество товара для приобретения ");
                            int purchase_count = Int32.Parse(Console.ReadLine());
                            if (purchase_count > 0)
                            {
                                if (product1count >= purchase_count)
                                {
                                    if (balance >= product1price * purchase_count)
                                    {
                                        if (transition1 == "none")
                                        {
                                            transition1 = "-" + product1price * product1PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product1name;
                                        }
                                        else if (transition2 == "none")
                                        {
                                            transition2 = "-" + product1price * product1PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product1name;
                                        }
                                        else if (transition3 == "none")
                                        {
                                            transition3 = "-" + product1price * product1PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product1name;
                                        }
                                        else
                                        {
                                            transition3 = transition2;
                                            transition2 = transition1;
                                            transition1 = "-" + product1price * product1PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product1name;
                                        }

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
                            Console.WriteLine("Выберите количество товара для приобретения");
                            int purchase_count = Int32.Parse(Console.ReadLine());
                            if (purchase_count > 0)
                            {
                                if (product2count >= purchase_count)
                                {
                                    if (balance >= product2price * purchase_count)
                                    {
                                        if (transition1 == "none")
                                        {
                                            transition1 = "-" + product2price * product2PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product2name;
                                        }
                                        else if (transition2 == "none")
                                        {
                                            transition2 = "-" + product2price * product2PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product2name;
                                        }
                                        else if (transition3 == "none")
                                        {
                                            transition3 = "-" + product2price * product2PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product2name;
                                        }
                                        else
                                        {
                                            transition3 = transition2;
                                            transition2 = transition1;
                                            transition1 = "-" + product2price * product2PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product2name;
                                        }

                                        balance -= product2price * purchase_count;
                                        product2count -= purchase_count;
                                        product2PurchasedCount += purchase_count;
                                        Console.WriteLine("Вы успешно приобрели товар №2");
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
                            Console.WriteLine("Выберите количество товара для приобретения");
                            int purchase_count = Int32.Parse(Console.ReadLine());
                            if (purchase_count > 0)
                            {
                                if (product3count >= purchase_count)
                                {
                                    if (balance >= product3price * purchase_count)
                                    {
                                        if (transition1 == "none")
                                        {
                                            transition1 = "-" + product3price * product3PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product3name;
                                        }
                                        else if (transition2 == "none")
                                        {
                                            transition2 = "-" + product3price * product3PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product3name;
                                        }
                                        else if (transition3 == "none")
                                        {
                                            transition3 = "-" + product3price * product3PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product3name;
                                        }
                                        else
                                        {
                                            transition3 = transition2;
                                            transition2 = transition1;
                                            transition1 = "-" + product3price * product3PurchasedCount + "$ вычтено из вашего счёта за покупку " + purchase_count + "x " + product3name;
                                        }

                                        balance -= product3price * purchase_count;
                                        product3count -= purchase_count;
                                        product3PurchasedCount += purchase_count;
                                        Console.WriteLine("Вы успешно приобрели товар №3");
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
                else if (from_user == "transactions")
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
                else if (from_user == "transactions:reset")
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
