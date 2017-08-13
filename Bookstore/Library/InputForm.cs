using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Library
{
   
    public partial class InputForm : Form
    {

        public InputForm()
        {
            InitializeComponent();
            
        }


        /*添加按钮*/
        private void button1_Click(object sender, EventArgs e)
        {
            string strPath = "stu.mdb";
            OleDbConnection myCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";");
            string booktype = comboBox1.SelectedIndex.ToString();
            switch (booktype)
            {
                case "0":booktype = "G 文化、科学、教育、体育";
                    break;
                case "1":
                    booktype = "H 语言、文字";
                    break;
                case "2":
                    booktype = "O 数理科学和化学";
                    break;
                case "3":
                    booktype = "T 工业技术";
                    break;
                case "4":
                    booktype = "V 航空、航天";
                    break;
                default:
                    booktype = "-1";
                    break;
            }
            if (booktype == "-1")
            {
                MessageBox.Show("选择图书分类");

            }
            else
            {
                /*判断输入框是否存在空白*/
                if (leftBox.Text == "" || priceBox.Text == "" || publisherBox.Text == "" || codeBox.Text == "" || authorBox.Text == "" || booktype == "" || nameBox.Text == "" )
                {
                    MessageBox.Show("请输入完整信息！");
                }
                /*向数据库中添加信息*/
                else
                {
                    string strsql = "insert into Booklist(bookcode,booktype,bookname,bookauthor,bookpublisher,bookprice,bookleft) values " +
                   "('" + codeBox.Text + "'," +
                   "'" + booktype + "'," +
                   "'" + nameBox.Text + "'," +
                   "'" + authorBox.Text + "'," +
                   "'" + publisherBox.Text + "'," +
                   "'" + priceBox.Text + "'," +
                   "'" + leftBox.Text + "')";
                    myCon.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = myCon;
                    cmd.CommandText = strsql;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    myCon.Dispose();
                    myCon.Close();
                    MessageBox.Show("添加成功");
                    codeBox.Text = nameBox.Text = authorBox.Text = publisherBox.Text = priceBox.Text = leftBox.Text = "";
                    comboBox1.SelectedIndex = -1;

                }
               
            }
      
        }

        /*清空按钮，清空所有输入框*/
        private void button2_Click(object sender, EventArgs e)
        {
            codeBox.Text = nameBox.Text = authorBox.Text = publisherBox.Text = priceBox.Text = leftBox.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        /*检测价格输入框是否输入的数字*/
        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*有效按键为数字、删除键、小数点，小数点的ASIIC码为46 */
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == '\b') || (e.KeyChar == 46)))
            {
                
                e.Handled = true;
                /*显示“请输入数字”标签*/
                Diglabel.Visible = true;
            }
            else
            {
                /*隐藏“请输入数字”标签*/
                Diglabel.Visible = false;
            }
        }

        /*检测库存输入框是否输入的数字*/
        private void leftBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*有效按键为数字、删除键*/
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == '\b')))
            {
                e.Handled = true;
                /*显示提示标签*/
                Diglabel2.Visible = true;
            }
            else
            {
                /*隐藏提示标签*/
                Diglabel2.Visible = false;
            }
        }

        /*检测库存条形码是否输入的数字*/
        private void codeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*有效按键为数字、删除键*/
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == '\b')))
            {
                e.Handled = true;
                /*显示提示标签*/
                Diglabel3.Visible = true;
            }
            else
            {
                /*隐藏提示标签*/
                Diglabel3.Visible = false;
            }
        }
    }
}
