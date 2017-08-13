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
    public partial class FatherForm : Form
    {

        private Timer Timer;

        public FatherForm()
        {
            InitializeComponent();
        }

        /*输入菜单*/
        private void 输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*判断是否已经打开该子窗口*/
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "InputForm")
                {
                    /*若已经打开，则将其激活，无需重复打开*/
                    childrenForm.Activate();
                    return;
                }         
            }
            /*若没有打开，则打开它*/
            InputForm frm = new InputForm();
            frm.MdiParent = this;
            frm.Show();
            frm.Dock = DockStyle.Fill;

        }

        /*销售菜单*/
        private void 销售ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*同理为了避免重复打开子窗口*/
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "SaleForm")
                {
                    childrenForm.Activate();
                    return;
                }
            }
            SaleForm frm = new SaleForm();
            frm.MdiParent = this;
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        /*统计菜单*/
        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*同理为了避免重复打开子窗口*/
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "DataForm")
                {
                    childrenForm.Activate();

                    return;
                }
                
            }
            DataForm frm = new DataForm();
            frm.MdiParent = this;
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        /*计时器模块，用于实时显示当前时间*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        
        /*实时显示当前时间*/
        private void FatherForm_Load(object sender, EventArgs e)
        {
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += new EventHandler(timer1_Tick);
            Timer.Start();
           
        }

        /*查询菜单*/
        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*布尔型全局变量，用来判断用户权限*/
            Global Access = new Global();
            /*同理为了避免重复打开子窗口*/
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == (Global.access==true?"QueryForm": "NoQueryForm"))
                {
                    childrenForm.Activate();
                    return;
                }
            }

            /*具有高级权限，则打开查询窗口*/
            if (Global.access == true)
            {
                QueryForm frm = new QueryForm();
                frm.MdiParent = this;
                frm.Show();
                frm.Dock = DockStyle.Fill;
            }
            /*不具有高级权限，则打开拒绝查询窗口*/
            else
            {
                NoQueryForm frm = new NoQueryForm();
                frm.MdiParent = this;
                frm.Show();
                frm.Dock = DockStyle.Fill;

            }
            

        }

        /*关闭主程序后，但会登录界面*/
        private void FatherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void 帮助ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*同理为了避免重复打开子窗口*/
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "HelpForm")
                {
                    childrenForm.Activate();

                    return;
                }

            }
            HelpForm frm = new HelpForm();
            frm.MdiParent = this;
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("图书销售系统\n版本号V1.0\n版权所有(C)蔡凯文，王安然", "关于");
        }
    }
}

