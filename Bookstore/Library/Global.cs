using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Library
{
    /*布尔型全局变量，用于记录用户是否具有高级权限*/
    class Global
    {
        public static bool access = false;
       
    }

    /*定义图书信息类，用于存储一个图书条目的信息*/
     public class BookInfo
    {
        public string code = "A";
        public string type = "A";
        public string name = "A";
        public string author = "A";
        public string publisher = "A";
        public double price = 0.0;
        public double saleprice = 0.0;
        public string saledate ="A";
        public int left = 0;

    }

    /*定义销售信息类，用于显示销售信息*/
    public class Item
    {

        public double sum=0;
        public double off=0;
        public double pay=0;

    }

}
