using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakes
{
    public class Components
    {
        public string Detail;
        readonly public int Price;
        static public List<List<string>> OrderLists = new List<List<string>> { Order.Forms, Order.Sizes, Order.Glazes, Order.Tastes, Order.Amounts };
        public Components(string Detail)
        {
            this.Detail = Detail + ", ";
            //форма
            if (OrderLists[0][0] == Detail)
                Price = 100;
            else if (OrderLists[0][1] == Detail)
                Price = 90;

            else if (OrderLists[0][2] == Detail)
                Price = 300;

            else if (OrderLists[0][3] == Detail)
                Price = 200;

            //размеры
            if (OrderLists[1][0] == Detail)
                Price = 50;

            else if (OrderLists[1][1] == Detail)
                Price = 70;

            else if (OrderLists[1][2] == Detail)
                Price = 100;

            else if (OrderLists[1][3] == Detail)
                Price = 200;

            //вкусы
            if (OrderLists[2][0] == Detail)
                Price = 60;

            else if (OrderLists[2][1] == Detail)
                Price = 70;

            else if (OrderLists[2][2] == Detail)
                Price = 100;

            else if (OrderLists[2][3] == Detail)
                Price = 200;

            //коржи
            if (OrderLists[3][0] == Detail)
                Price = 60;

            else if (OrderLists[3][1] == Detail)
                Price = 70;

            else if (OrderLists[3][2] == Detail)
                Price = 100;

            else if (OrderLists[3][3] == Detail)
                Price = 200;


            if (OrderLists[4][0] == Detail)
                Price = 60;

            else if (OrderLists[4][1] == Detail)
                Price = 70;

            else if (OrderLists[4][2] == Detail)
                Price = 100;

            else if (OrderLists[4][3] == Detail)
                Price = 200;
        }
    }
}