/********************************更新日志*************************************/
/*2016-3-27：程序主界面设计，子界面仅完成【输入】界面设计包括完整按钮；
/*           （学习C#窗体程序基本结构）
/*2016-3-28：在Sql sever中创建数据库，但Sql sever management studio"用户名+密码"登录故障，调试一天无果；
/*           （学习Sql sever数据库基本操作，及C#中连接Sql sever的方法）
/*2016-3-39：在Access中创建数据库，创建数据表booklist；
/*           完成【输入】界面设计；
/*          【输入】界面中经调试，成功连接数据库，并可实现向数据库中添加数据功能；
/*          （学习C#中操作Access数据库的方法；学会使用全局变量）
/*2016-3-30：设计【销售】界面；
/*           （学习使用调用公共类）
/*2016-3-31：更新【销售】界面，可弹出子窗体显示商品信息；
/*           （学习委托与事件）
/*2016-4-1：更新【销售】界面；
/*          更新销售界面函数逻辑；
/*          重新设计商品信息等数据结构；
/*          （学习委托与事件）
/*2016-4-4：重新设计完善图书数据库结构；          
/*2016-4-6：重新设计完善图书数据库结构；
/*          完成【销售】界面及销售逻辑编程；
/*          重新补充完善【输入】界面；
/*2016-4-7：完成【统计】界面代码、设计；
/*         （学习chart控件操作）
/*2016-4-8：完成【查询】界面代码、设计；
            完成【拒绝查询】界面代码、设计；
/*2016-4-10：完善数据库图表结构；
            完善程序细节设计，如提示输入完整图书信息，价格框、条形码框、库存框只能输入数字；
/*2016-4-11：完成程序打包
/*2016-4-14:添加【帮助】菜单，包括操作说明和关于。
/**************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{

    static class Program
    {
        

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());          
        }

    }
}
