using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "hello ";
            string word2 = "world";
            Console.WriteLine(string.Concat(word1, word2));

            int num1 = 5;
            int num2 = 10;
            int addition = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num1 * num2;
            int division = num1 / num2;
            Console.WriteLine((addition, subtraction, multiplication, division));

            Console.WriteLine("Введите вашу фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваше имя");
            string name =  Console.ReadLine();
            Console.WriteLine("Введите ваше отчество");
            string patronymic = Console.ReadLine(); 
            Console.WriteLine($"Привет, {name} {surname} {patronymic}");

            //player
            double hp = 2500;
            double damage = 40;
            double armor = 100;

            //monster
            double hp2 = 3000;
            double damage2 = 25;
            double armor2 = 95;

            while(hp > 0)
            {
                double damage_recieved = Math.Pow(damage2, 2) / armor;
                hp -= damage_recieved;
                Console.WriteLine("Здоровье игрока:" + hp);
            }
            Console.WriteLine("Игра окончена");

            Console.ReadKey();
        }
    }
}
