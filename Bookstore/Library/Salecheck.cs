using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public delegate void ClickDelegateHander(BookInfo checkmyBookinfo );
    public partial class Salecheck : Form
    {
        public event ClickDelegateHander ClickEvent;
        public BookInfo checkmyBookinfo = new BookInfo();
        public Item myItem = new Item();

        /*9折出售按钮*/
        private void button1_Click(object sender, EventArgs e)
        {
            /*将SaleForm中传入的图书信息中的销售价格定为定价的0.9倍*/
            this.checkmyBookinfo.saleprice = 0.9 * this.checkmyBookinfo.price;
            /*记录当前销售日期*/
            this.checkmyBookinfo.saledate = DateTime.Now.ToString("yyyy-MM-dd");
            /*触发事件*/
            if (ClickEvent != null)
            {

                ClickEvent(this.checkmyBookinfo);
            }
            this.Hide();
        }
        
        /*原价出售按钮*/
        private void button2_Click(object sender, EventArgs e)
        {
            /*将SaleForm中传入的图书信息中的销售价格定为与定价一致*/
            this.checkmyBookinfo.saleprice =this.checkmyBookinfo.price;
            /*记录当前销售日期*/
            this.checkmyBookinfo.saledate = DateTime.Now.ToString("yyyy-MM-dd");
            /*触发事件*/
            if (ClickEvent != null)
            {
                ClickEvent(this.checkmyBookinfo);
            }
            this.Hide();

        }
        public Salecheck()
        {
            InitializeComponent();
        }

        public Salecheck(BookInfo myBookinfo)
            {
            InitializeComponent();
            this.checkmyBookinfo = myBookinfo;

            }

        /*显示传入的图书商品信息*/
        private void Salecheck_Load(object sender, EventArgs e)
        {
            label1.Text = this.checkmyBookinfo.name;
            label2.Text = Convert.ToString(this.checkmyBookinfo.price);
            label3.Text = this.checkmyBookinfo.author;
        }
    }
}
