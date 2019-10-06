using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Kalculate
    {       
        public void ChooseShop(Person[] a, int i, Shop dics, Shop pyat)
        {
            Console.WriteLine("Введите номер магазина: 1)Дикси 2)Пяиерочка");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    int j = 0;
                    while (j != 4)
                    {
                        Console.WriteLine("Выберите продукты которые хотите купить(введите номер):1)Помидор 30р 2)Апельсин 10р 3)Мясо 70р 4)Закончить покупку");
                        j = Convert.ToInt32(Console.ReadLine());
                        if (j == 4)
                        {
                            
                            break;
                            
                        }
                        else
                        {
                            a[i].money -= dics.products[j].stoimost;
                        }
                    }
                    break;
                case 2:
                    int t = 0;
                    while (t != 4)
                    {
                        Console.WriteLine("Выберите продукты которые хотите купить(введите номер):1)Помидор 30р 2)Апельсин 10р 3)Мясо 70р 4)Закончить покупку");
                        t = Convert.ToInt32(Console.ReadLine());
                        if (t == 4)
                        {
                            break;
                        }
                        else
                        {
                            a[i].money -= dics.products[t].stoimost;
                        }
                    }
                    break;

            }
               

        }

    }
}
