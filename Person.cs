using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Person
    {
        public string name;
        public int money;
        public void InputInfo(Person[] a, int b)
        {                          
                Console.WriteLine("Введите имя:");
                a[b].name = Console.ReadLine();
                Console.WriteLine("Введите бюджет:");
                a[b].money = Convert.ToInt32(Console.ReadLine());           
        }
        public void GetInfo()
        {           
                Console.WriteLine($"Вашее имя:{name} Ваш бюджет{money}");          
        }
    }
}
