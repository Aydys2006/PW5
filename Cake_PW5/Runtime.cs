using System;

namespace Cakes
{
    public class Terminal
    {
        public delegate void del();
        static public del c = Console.Clear;

        static public int y = 3;
        static public int yL0 = y;
        static void Main()
        {
            Console.Title = "Кафешка";
            c();
            Console.CursorVisible = false;
            Order.MenuL0();
            Console.SetCursorPosition(0, yL0);
            Console.Write(">");
            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                Cursor(key);
            }

        }

        private static void Cursor(ConsoleKey key)
        {
            bool inSubMenu = false;
            if (y == 2 && key == ConsoleKey.UpArrow && !inSubMenu)
            {
                y++;
            }
            switch (key, y, inSubMenu)
            {
                case (ConsoleKey.Escape, not 99, false):
                    c();
                    System.Environment.Exit(0);
                    break;
                case (ConsoleKey.UpArrow, not 3, false):
                    int yb = y;
                    y--;
                    Console.SetCursorPosition(0, yb);
                    Console.Write("  ");
                    break;
                case (ConsoleKey.DownArrow, < 8, false):
                    int yb1 = y;
                    y++;
                    Console.SetCursorPosition(0, yb1);
                    Console.Write("  ");
                    break;
                case (ConsoleKey.Enter, 3, false):
                    inSubMenu = true;
                    c();
                    yL0 = y;
                    Console.WriteLine("Выбор Формы");
                    foreach (var punkt in Order.Forms)
                    {
                        Console.SetCursorPosition(2, Order.Forms.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    y = 0;
                    Console.SetCursorPosition(99, y);
                    while (inSubMenu)
                    {
                        int x = 0;
                        if (y <= Order.Forms.Count && y != 0)
                        {
                            x = Order.Forms[y - 1].Length + 2;
                        }
                        else if (y == 0)
                        {
                            x = 99;
                        }
                        key = Console.ReadKey(true).Key;
                        switch (key, y)
                        {
                            case (ConsoleKey.UpArrow, not 0 and not 1):
                                int yb11 = y;
                                y--;
                                Console.SetCursorPosition(x, yb11);
                                Console.Write("     ");
                                break;
                            case (ConsoleKey.DownArrow, < 4):
                                int yb111 = y;
                                y++;
                                Console.SetCursorPosition(x, yb111);
                                Console.Write("    ");
                                break;
                            case (ConsoleKey.Escape, not 999):
                                y = yL0;
                                Main();
                                break;
                            case (ConsoleKey.Enter, not 999):
                                if (Order.Box.Count == 0 && y != 0)
                                {
                                    Order.Box.Add(new Order(
                                        view: new Components(Order.Forms[y - 1]).Detail,
                                        price: new Components(Order.Forms[y - 1]).Price)
                                        );
                                }
                                else if (y != 0)
                                {
                                    Order.Box[0].form = new Components(Order.Forms[y - 1]).Detail;
                                    Order.Box[0].Price += new Components(Order.Forms[y - 1]).Price;
                                }
                                inSubMenu = false;
                                //MessageBox.Show("Test");
                                y = yL0;
                                Main();
                                break;
                        }
                        if (y != 0)
                        {
                            Console.SetCursorPosition(Order.Forms[y - 1].Length + 2, y);
                            Console.Write(" <" + y);
                        }
                    }
                    break;
                case (ConsoleKey.Enter, 4, false):
                    inSubMenu = true;
                    c();
                    yL0 = y;
                    Console.WriteLine("Выбор Размеров");
                    foreach (var punkt in Order.Sizes)
                    {
                        Console.SetCursorPosition(2, Order.Sizes.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    y = 0;
                    Console.SetCursorPosition(99, y);
                    while (inSubMenu)
                    {
                        int x = 0;
                        if (y <= Order.Sizes.Count && y != 0)
                        {
                            x = Order.Sizes[y - 1].Length + 2;
                        }
                        else if (y == 0)
                        {
                            x = 99;
                        }
                        key = Console.ReadKey(true).Key;
                        switch (key, y)
                        {
                            case (ConsoleKey.UpArrow, not 0 and not 1):
                                int yb11 = y;
                                y--;
                                Console.SetCursorPosition(x, yb11);
                                Console.Write("     ");
                                break;
                            case (ConsoleKey.DownArrow, < 4):
                                int yb111 = y;
                                y++;
                                Console.SetCursorPosition(x, yb111);
                                Console.Write("    ");
                                break;
                            case (ConsoleKey.Escape, not 999):
                                y = yL0;
                                Main();
                                break;
                            case (ConsoleKey.Enter, not 999):
                                if (Order.Box.Count == 0 && y != 0)
                                {
                                    Order.Box.Add(new Order(
                                        size: new Components(Order.Sizes[y - 1]).Detail,
                                        price: new Components(Order.Sizes[y - 1]).Price)
                                        );
                                }
                                else if (y != 0)
                                {
                                    Order.Box[0].size = new Components(Order.Sizes[y - 1]).Detail;
                                    Order.Box[0].Price += new Components(Order.Sizes[y - 1]).Price;
                                }
                                inSubMenu = false;
                                //MessageBox.Show("Test");
                                y = yL0;
                                Main();
                                break;
                        }
                        if (y != 0)
                        {
                            Console.SetCursorPosition(Order.Sizes[y - 1].Length + 2, y);
                            Console.Write(" <" + y);
                        }
                    }
                    break;

                //удачный блок:
                case (ConsoleKey.Enter, 5, false):
                    inSubMenu = true;
                    c();
                    yL0 = y;
                    Console.WriteLine("Выбор Вкусов");
                    foreach (var punkt in Order.Tastes)
                    {
                        Console.SetCursorPosition(2, Order.Tastes.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    y = 0;
                    Console.SetCursorPosition(99, y);
                    while (inSubMenu)
                    {
                        int x = 0;
                        if (y <= Order.Tastes.Count && y != 0)
                        {
                            x = Order.Tastes[y - 1].Length + 2;
                        }
                        else if (y == 0)
                        {
                            x = 99;
                        }
                        key = Console.ReadKey(true).Key;
                        switch (key, y)
                        {
                            case (ConsoleKey.UpArrow, not 0 and not 1):
                                int yb11 = y;
                                y--;
                                Console.SetCursorPosition(x, yb11);
                                Console.Write("     ");
                                break;
                            case (ConsoleKey.DownArrow, < 4):
                                int yb111 = y;
                                y++;
                                Console.SetCursorPosition(x, yb111);
                                Console.Write("    ");
                                break;
                            case (ConsoleKey.Escape, not 999):
                                y = yL0;
                                Main();
                                break;
                            case (ConsoleKey.Enter, not 999):
                                if (Order.Box.Count == 0 && y != 0)
                                {
                                    Order.Box.Add(new Order(
                                        taste: new Components(Order.Tastes[y - 1]).Detail,
                                        price: new Components(Order.Tastes[y - 1]).Price)
                                        );
                                }
                                else if (y != 0)
                                {
                                    Order.Box[0].taste = new Components(Order.Tastes[y - 1]).Detail;
                                    Order.Box[0].Price += new Components(Order.Tastes[y - 1]).Price;
                                }
                                inSubMenu = false;
                                //MessageBox.Show("Test");
                                y = yL0;
                                Main();
                                break;
                        }
                        if (y != 0)
                        {
                            Console.SetCursorPosition(Order.Tastes[y - 1].Length + 2, y);
                            Console.Write(" <" + y);
                        }
                    }
                    break;
                case (ConsoleKey.Enter, 6, false):
                    inSubMenu = true;
                    c();
                    yL0 = y;
                    Console.WriteLine("Выбор Количества коржей");
                    foreach (var punkt in Order.Amounts)
                    {
                        Console.SetCursorPosition(2, Order.Amounts.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    y = 0;
                    Console.SetCursorPosition(99, y);
                    while (inSubMenu)
                    {
                        int x = 0;
                        if (y <= Order.Amounts.Count && y != 0)
                        {
                            x = Order.Amounts[y - 1].Length + 2;
                        }
                        else if (y == 0)
                        {
                            x = 99;
                        }
                        key = Console.ReadKey(true).Key;
                        switch (key, y)
                        {
                            case (ConsoleKey.UpArrow, not 0 and not 1):
                                int yb11 = y;
                                y--;
                                Console.SetCursorPosition(x, yb11);
                                Console.Write("     ");
                                break;
                            case (ConsoleKey.DownArrow, < 4):
                                int yb111 = y;
                                y++;
                                Console.SetCursorPosition(x, yb111);
                                Console.Write("    ");
                                break;
                            case (ConsoleKey.Escape, not 999):
                                y = yL0;
                                Main();
                                break;
                            case (ConsoleKey.Enter, not 999):
                                if (Order.Box.Count == 0 && y != 0)
                                {
                                    Order.Box.Add(new Order(
                                        amount: new Components(Order.Amounts[y - 1]).Detail,
                                        price: new Components(Order.Amounts[y - 1]).Price)
                                        );
                                }
                                else if (y != 0)
                                {
                                    Order.Box[0].amount = new Components(Order.Amounts[y - 1]).Detail;
                                    Order.Box[0].Price += new Components(Order.Amounts[y - 1]).Price;
                                }
                                inSubMenu = false;
                                //MessageBox.Show("Test");
                                y = yL0;
                                Main();
                                break;
                        }
                        if (y != 0)
                        {
                            Console.SetCursorPosition(Order.Amounts[y - 1].Length + 2, y);
                            Console.Write(" <" + y);
                        }
                    }
                    break;
                case (ConsoleKey.Enter, 7, false):
                    inSubMenu = true;
                    c();
                    yL0 = y;
                    Console.WriteLine("Выбор Глазури");
                    foreach (var punkt in Order.Glazes)
                    {
                        Console.SetCursorPosition(2, Order.Glazes.IndexOf(punkt) + 1);
                        Console.WriteLine(punkt);
                    }
                    y = 0;
                    Console.SetCursorPosition(99, y);
                    while (inSubMenu)
                    {
                        int x = 0;
                        if (y <= Order.Glazes.Count && y != 0)
                        {
                            x = Order.Glazes[y - 1].Length + 2;
                        }
                        else if (y == 0)
                        {
                            x = 99;
                        }
                        key = Console.ReadKey(true).Key;
                        switch (key, y)
                        {
                            case (ConsoleKey.UpArrow, not 0 and not 1):
                                int yb11 = y;
                                y--;
                                Console.SetCursorPosition(x, yb11);
                                Console.Write("     ");
                                break;
                            case (ConsoleKey.DownArrow, < 4):
                                int yb111 = y;
                                y++;
                                Console.SetCursorPosition(x, yb111);
                                Console.Write("    ");
                                break;
                            case (ConsoleKey.Escape, not 999):
                                y = yL0;
                                Main();
                                break;
                            case (ConsoleKey.Enter, not 999):
                                if (Order.Box.Count == 0 && y != 0)
                                {
                                    Order.Box.Add(new Order(
                                        glaze: new Components(Order.Glazes[y - 1]).Detail,
                                        price: new Components(Order.Glazes[y - 1]).Price)
                                        );
                                }
                                else if (y != 0)
                                {
                                    Order.Box[0].glaze = new Components(Order.Glazes[y - 1]).Detail;
                                    Order.Box[0].Price += new Components(Order.Glazes[y - 1]).Price;
                                }
                                inSubMenu = false;
                                //MessageBox.Show("Test");
                                y = yL0;
                                Main();
                                break;
                        }
                        if (y != 0)
                        {
                            Console.SetCursorPosition(Order.Glazes[y - 1].Length + 2, y);
                            Console.Write(" <" + y);
                        }
                    }
                    break;
                // чек
                case (ConsoleKey.Enter, 8, false):
                    Order.RenderCheck();
                    break;
            }
            if (y != 2 && key != ConsoleKey.Enter && !inSubMenu)
            {
                Console.SetCursorPosition(0, y);
                Console.Write(">");
            }

        }
    }
}