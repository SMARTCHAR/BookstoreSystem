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
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        /*加载窗口时显示“所有图书”库存信息*/
        private void QueryForm_Load(object sender, EventArgs e)
        {
            string mySql = "select bookcode as 条形码,bookname as 书名,bookauthor as 作者,bookpublisher as 出版社,booktype as 分类 ,bookprice as 定价 ,bookleft as 库存 from Booklist ";
            string strPath = "stu.mdb";
            OleDbConnection myCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";");
            OleDbCommand myCommand = new OleDbCommand(mySql, myCon);
            OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCommand);
            DataTable myTable = new DataTable();
            myCon.Open();
            myAdapter.Fill(myTable);
            this.dataGridView1.DataSource = myTable;
            myCommand.Dispose();
            myAdapter.Dispose();
            myCon.Dispose();
            myCon.Close();
        }

        /*当选择框中选择的条目发生改变时*/
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choosetype = comboBox1.SelectedIndex.ToString();
            textBox1.Text = textBox2.Text = "";
            switch (choosetype)
            {
                case "0":
                    choosetype = "All";
                    break;
                case "1":
                    choosetype = "G 文化、科学、教育、体育";
                    break;
                case "2":
                    choosetype = "H 语言、文字";
                    break;
                case "3":
                    choosetype = "O 数理科学和化学";
                    break;
                case "4":
                    choosetype = "T 工业技术";
                    break;
                case "5":
                    choosetype = "V 航空、航天";
                    break;
                default:
                    choosetype = "-1";
                    break;
            }
            string mySql = "select bookcode as 条形码,bookname as 书名,bookauthor as 作者,bookpublisher as 出版社,booktype as 分类 ,bookprice as 定价 ,bookleft as 库存 from Booklist where booktype = '" + choosetype+"' ";
            if (choosetype == "-1")
            {
                return;

            }
            else
            {
                /*选择“所有图书”时*/
                if (choosetype == "All")
                {
                    mySql = "select bookcode as 条形码,bookname as 书名,bookauthor as 作者,bookpublisher as 出版社,booktype as 分类 ,bookprice as 定价 ,bookleft as 库存 from Booklist";
                }
                string strPath = "stu.mdb";
                OleDbConnection myCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";");
                OleDbCommand myCommand = new OleDbCommand(mySql, myCon);
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCommand);
                DataTable myTable = new DataTable();
                myCon.Open();
                myAdapter.Fill(myTable);
                this.dataGridView1.DataSource = myTable;
                myCommand.Dispose();
                myAdapter.Dispose();
                myCon.Dispose();
                myCon.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        /*输入图书名称框*/
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
            string mySql = "select bookcode as 条形码,bookname as 书名,bookauthor as 作者,bookpublisher as 出版社,booktype as 分类 ,bookprice as 定价 ,bookleft as 库存 from Booklist where bookname = '" + textBox2.Text + "' ";
            string strPath = "stu.mdb";
            OleDbConnection myCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";");
            OleDbCommand myCommand = new OleDbCommand(mySql, myCon);
            OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCommand);
            DataTable myTable = new DataTable();
            myCon.Open();
            /*将数据表绑定到dataGridView视图中*/
            myAdapter.Fill(myTable);
            this.dataGridView1.DataSource = myTable;
            myCommand.Dispose();
            myAdapter.Dispose();
            myCon.Dispose();
            myCon.Close();
        }

        /*输入图书名称框*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox2.Text = "";
            string mySql = "select bookcode as 条形码,bookname as 书名,bookauthor as 作者,bookpublisher as 出版社,booktype as 分类 ,bookprice as 定价 ,bookleft as 库存 from Booklist where bookcode = '" + textBox1.Text + "' ";
            string strPath = "stu.mdb";
            OleDbConnection myCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";");
            OleDbCommand myCommand = new OleDbCommand(mySql, myCon);
            OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCommand);
            DataTable myTable = new DataTable();
            myCon.Open();
            /*将数据表绑定到dataGridView视图中*/
            myAdapter.Fill(myTable);
            this.dataGridView1.DataSource = myTable;
            myCommand.Dispose();
            myAdapter.Dispose();
            myCon.Dispose();
            myCon.Close();

        }
    }

}
