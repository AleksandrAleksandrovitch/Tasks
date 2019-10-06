using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество пользователей:");
            int n = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[n];
            Kalculate kalculate = new Kalculate();
            Product[] a = new Product[3];
            a[0] = new Product();
            a[1] = new Product();
            a[2] = new Product();
            a[0].name = "Помидор";
            a[0].stoimost = 30;
            a[1].name = "Апельсин";
            a[1].stoimost = 10;
            a[2].name = "Мясо";
            a[2].stoimost = 70;
            Shop dicsi = new Shop("Дикcи", a);
            Shop pyaterocchka = new Shop("Пятерочка", a);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i+1}го покупателя");
                people[i] = new Person {};
                people[i].InputInfo(people, i);
                kalculate.ChooseShop(people, i, dicsi, pyaterocchka);
                people[i].GetInfo();
                   

            }
        }
    }
}
