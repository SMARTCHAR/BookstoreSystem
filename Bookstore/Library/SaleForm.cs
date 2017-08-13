using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library
{
    public partial class SaleForm : Form
    {
        /*定义图书信息型变量的堆栈*/
        public Stack<BookInfo> myStack = new Stack<BookInfo>();
        /*定义销售信息型变量*/
        Item myItem = new Item();


        public SaleForm()
        {
            InitializeComponent();
        }

        /*计算商品销售金额信息*/
        public void getMessage(BookInfo backmybookinfo)
        {
            this.myItem.sum = this.myItem.sum + backmybookinfo.price;
            this.myItem.pay = this.myItem.pay + backmybookinfo.saleprice;
            this.myItem.off = this.myItem.sum - this.myItem.pay;           
            this.label2.Text = this.myItem.sum.ToString("0.0")+"元";
            this.label4.Text = this.myItem.off.ToString("0.0")+"元";
            this.label6.Text = this.myItem.pay.ToString("0.0"+"元");
            /*在列表中显示当前图书的价格等信息*/
            string mark = "，";
            this.listBox1.Items.Add(backmybookinfo.name + mark + backmybookinfo.author + mark + backmybookinfo.saleprice + "元");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            /*将当前图书存入堆栈中*/
            this.myStack.Push(backmybookinfo);
            /*清空输入框*/
            this.textBox1.Text = "";

        }


        private void button1_Click(object sender, EventArgs e)
        {

            BookInfo myBookinfo = new BookInfo();
            /*连接数据库*/
            string strPath = "stu.mdb";
            OleDbConnection myCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";");
            /*查询数据库数据*/
            string myQuery = "select bookcode,booktype,bookname,bookauthor,bookprice,bookpublisher,bookleft from Booklist where bookname='" + this.textBox1.Text + "'or bookcode='" + this.textBox1.Text + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myCon);
            myCon.Open();
            OleDbDataReader reader = myCommand.ExecuteReader();
            if (reader.Read())
            {
                /*将查询到的图书信息存入局部图书信息型变量中，用来传递给SaleCheckForm窗口*/
                myBookinfo.code = reader["bookcode"].ToString();
                myBookinfo.publisher = reader["bookpublisher"].ToString();
                myBookinfo.type = reader["booktype"].ToString();
                myBookinfo.name = reader["bookname"].ToString();
                myBookinfo.author = reader["bookauthor"].ToString();
                myBookinfo.price = Convert.ToDouble(reader["bookprice"].ToString());
                myBookinfo.left = Convert.ToInt16(reader["bookleft"].ToString());
                /*若该书库存为零*/
                if (myBookinfo.left == 0)
                {
                    MessageBox.Show("该书售罄！", "提示");
                    textBox1.Text = "";
                    return;
                }
                /*打开SaleCheckForm窗口，显示具体商品信息*/
                Salecheck frm = new Salecheck(myBookinfo);
                /*注册事件，当在SaleCheckForm窗口中点击“打9折销售”或者“原价销售”时执行getMessage事件*/
                frm.ClickEvent += new ClickDelegateHander(getMessage);
                frm.Show();

            }
            /*若没查询到该图书*/
            else
            {
                MessageBox.Show("无记录！","提示");
                textBox1.Text = "";
            }
            myCommand.Dispose();
            reader.Close();
            myCon.Dispose();
            myCon.Close();

        }

        /*加载窗口时，各项金额初始化为0*/
        private void SaleForm_Load(object sender, EventArgs e)
        {

            label2.Text = "0";
            label4.Text = "0";
            label6.Text = "0";
            listBox1.Items.Clear();
            this.textBox1.Text = "";
            this.myItem.sum = this.myItem.pay = this.myItem.off = 0.0;
            this.myStack.Clear();


        }

        /*结算按钮*/
        private void button2_Click(object sender, EventArgs e)
        {
            string strPath = "stu.mdb";
            OleDbConnection myCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";");
            myCon.Open();
            /*将堆栈中的图书信息型信息逐个取出*/
            foreach (BookInfo temp in myStack)
            {
                /*将数据库中该图书的库存量减一*/
                temp.left = temp.left - 1;
                string myUpdate = "update Booklist set bookleft='" + temp.left + "' where bookname='" + temp.name + "'";
                OleDbCommand cmd = new OleDbCommand(myUpdate, myCon);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                string myInsert = "insert into Salelist(bookcode,booktype,bookname,bookauthor,bookpublisher,bookprice,saleprice,saledate) values('"+temp.code+ "','" + temp.type + "','" + temp.name+ "','"+temp.author+"','"+temp.publisher+"',"+temp.price+","+temp.saleprice+",'"+temp.saledate+"')";
              OleDbCommand myCommand = new OleDbCommand(myInsert, myCon);
              myCommand.ExecuteNonQuery();
              myCommand.Dispose();
              
            }
            myCon.Dispose();
            myCon.Close();
            MessageBox.Show("结算成功，下一位！");
            myStack.Clear();
            SaleForm_Load(null, null);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaleForm_Load(null,null);
        }
    }
}
