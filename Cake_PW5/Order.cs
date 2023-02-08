using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Cakes
{
    public class Order
    {
        public string form = "";
        public string size = "";
        public string taste = "";
        public string amount = "";
        public string glaze = "";
        public int Price = 0;
        static public List<string> Forms = new List<string>()
        {"Круглаый - 100р", "Полусфера - 90р", "Квадрат - 200р", "Свой стиль - 300р" };

        public static List<string> Sizes = new List<string>()
        {"Маленький - 50р", "Средний - 70р", "Большой - 100р", "Очень большой - 200р"};

        public static List<string> Tastes = new List<string>()
        { "Морковный - 60р", "Крем - 70р", "Шоколад - 100", "Клубника - 200р" };

        public static List<string> Amounts = new List<string>()
        {"1 коржик 20р", "2 коржика - 40р", "3 коржа - 50р", "4 коржа - 80р"};

        public static List<string> Glazes = new List<string>()
        {"Розовая - 30р", "Тыква - 20р", "Зелёный - 35р", "Красный - 50р"};
        public static List<Order> Box = new List<Order> { };
        static public void MenuL0()
        {
            var n = "\n  ";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($" Велком ту Кирби Кафетерий!!" +
                $"\n Выберите компоненты торта:\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 40; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(2, 4 - 1);
            Console.Write($"Форма" + n +
                $"Размер" + n +
                $"Вкус" + n +
                $"Количество коржиков" + n +
                $"Глазурь" + n +
                $"Я закончил" + n);
            if (Box.Count != 0)
            {
                Console.WriteLine($"С вас: {Box[0].Price}");
                Console.Write("Ваш заказ:");
                string order = $" {Box[0].form}{Box[0].size}{Box[0].taste}{Box[0].amount}{Box[0].glaze}";
                Console.Write(order);
                Console.SetCursorPosition(order.Length + "Ваш заказ:".Length - 2, 10);
                Console.Write("  ");

            }
        }

        public static void RenderCheck()
        {
            if (Box.Count != 0)
            {
                string order = $" {Box[0].form}{Box[0].size}{Box[0].taste}{Box[0].amount}{Box[0].glaze}";
                if (Box[0].form != "" && Box[0].size != "" && Box[0].taste != "" && Box[0].amount != "" && Box[0].glaze != "")
                {
                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "заказ.txt", $"\nЗаказ от {DateTime.Now}\r\n\tЗаказ: {order}\r\n\tЦена: {Box[0].Price} руб\n");
                    Terminal.c();
                    Console.WriteLine("Ваш заказ оформлен");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.SetCursorPosition(0, 11);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("Вы не выбрали все компоненты торта!!!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Thread.Sleep(5000);
                    Console.SetCursorPosition(0, 11);
                    Console.Write("\t\t\t\t\t\t\t");
                }
            }
            else
            {
                Console.SetCursorPosition(0, 10);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Вы не выбрали никакие компоненты торта!!!");
                Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(5000);
                Console.SetCursorPosition(0, 10);
                Console.Write("\t\t\t\t\t\t\t\t");
            }

        }

        public Order()
        {

        }
        public Order(string amount = "", string view = "", string taste = "", string size = "", int price = 0, string glaze = "")
        {
            form = view;
            this.amount = amount;
            this.taste = taste;
            this.size = size;
            this.Price = price;
            this.glaze = glaze;
        }



    }
}