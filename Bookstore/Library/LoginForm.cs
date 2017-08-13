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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /*打开登录框是自动填充设定要的账号密码，方便调试，实际使用时不应自动填充*/
        private void LoginForm_Load(object sender, EventArgs e)
        {


        }

        /*退出程序*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*登录按钮*/
        private void button1_Click(object sender, EventArgs e)
        {
            /*连接数据库*/
            string strPath = "stu.mdb";
            OleDbConnection myCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";");
            string strCheck = "select username,password,access from Userlist where username='" + this.textBox1.Text + "'and password='" + this.textBox2.Text + "'";
            OleDbCommand myCommand = new OleDbCommand(strCheck, myCon);
            myCon.Open();
            /*查询数据库的Userlist表中是否存在此用户名和密码*/
            OleDbDataReader myReader = myCommand.ExecuteReader();
            /*若存在此用户名和密码，则登录成功，打开程序主界面*/
            if (myReader.Read())
            {
                Global Access = new Global();
                Global.access = Convert.ToBoolean(myReader["access"]);
                FatherForm frm = new FatherForm();
                this.Hide();
                frm.Show();
            }
            /*若不存在此用户名和密码，则登录失败*/
            else
            {
                MessageBox.Show("登录失败，请核对用户名及密码！");
                /*清空输入框*/
                this.textBox1.Text = "";
                this.textBox2.Text = "";
            }
            /*释放数据库连接资源*/
            myCommand.Dispose();
            myReader.Close();
            myCon.Close();

        }

        /*登录窗口关闭时，关闭程序的线程*/
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
