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
using System.Windows.Forms.DataVisualization.Charting;



namespace Library
{
    public partial class DataForm : Form
    {

        public DataForm()
        {
            InitializeComponent();               

        }

        /*当选择框中选择的条目发生改变时*/
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*清空图标中的图像*/
            chart1.Series[0].Points.Clear();
            /*获取当前的月份*/
            DateTime dateNow = DateTime.Now;
            int monNow = dateNow.Month;
            /*利用数组来存储总销售金额*/
            double[] sum = new double[12];
            string choosetype = comboBox1.SelectedIndex.ToString();
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
            string mySql = "select bookcode as 条形码,bookname as 书名 ,bookauthor as 作者,bookpublisher as 出版社,booktype as 分类 ,bookprice as 定价 ,saleprice as 售价 ,saledate as 日期 from Salelist where booktype ='" + choosetype + "'";
            /*判断是否选择某一项*/
            if (choosetype == "-1")
            {
                MessageBox.Show("未选择分类");

            }
            else
            {
                /*当选择所有图书时*/
                if (choosetype == "All")
                {
                    mySql = "select bookcode as 条形码,bookname as 书名 ,bookauthor as 作者,bookpublisher as 出版社,booktype as 分类 ,bookprice as 定价 ,saleprice as 售价 ,saledate as 日期 from Salelist ";
                }
                
                string strPath = "stu.mdb";
                OleDbConnection myCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";");
                OleDbCommand myCommand = new OleDbCommand(mySql, myCon);
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCommand);
                DataTable myTable = new DataTable();
                myCon.Open();
                myAdapter.Fill(myTable);
                /*将数据表绑定到dataGridView视图中*/
                this.dataGridView1.DataSource = myTable;
               for (int i = 0; i < myTable.Rows.Count ; i++)
                {
                   /*逐个查询月份，将相同的月份的金额求和，存入数组中，数组的下标即月份*/
                    if (Convert.ToDateTime(myTable.Rows[i]["日期"]).Month == monNow)
                        sum[monNow] += Convert.ToDouble(myTable.Rows[i]["售价"]);
                    else if (Convert.ToDateTime(myTable.Rows[i]["日期"]).Month == monNow - 1)
                        sum[monNow - 1] += Convert.ToDouble(myTable.Rows[i]["售价"]);
                    else if (Convert.ToDateTime(myTable.Rows[i]["日期"]).Month == monNow - 2)
                        sum[monNow - 2] += Convert.ToDouble(myTable.Rows[i]["售价"]);
                     
                }
               /*向图表中添加信息*/
                chart1.Series[0].Points.AddXY(monNow - 2, sum[monNow - 2]);
                chart1.Series[0].Points.AddXY(monNow - 1, sum[monNow - 1]);
                chart1.Series[0].Points.AddXY(monNow, sum[monNow]);
                myCommand.Dispose();
                myAdapter.Dispose();
                myCon.Dispose();
                myCon.Close();
            }
        }

        /*加载窗口后显示所有图书的库存信息，操作方法同上*/
        private void DataForm_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            chart1.Series[0].Points.Clear();
            DateTime dateNow = DateTime.Now;
            int monNow = dateNow.Month;
            double[] sum = new double[12];
            string mySql = "select bookcode as 条形码, bookname as 书名 ,bookauthor as 作者,bookpublisher as 出版社,booktype as 分类 ,bookprice as 定价 ,saleprice as 售价 ,saledate as 日期 from Salelist ";
            string strPath = "stu.mdb";
            OleDbConnection myCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strPath + ";");
            OleDbCommand myCommand = new OleDbCommand(mySql, myCon);
            OleDbDataAdapter myAdapter = new OleDbDataAdapter(myCommand);
            DataTable myTable = new DataTable();
            myCon.Open();
            myAdapter.Fill(myTable);
            this.dataGridView1.DataSource = myTable;
            for (int i = 0; i < myTable.Rows.Count; i++)
            {

                if (Convert.ToDateTime(myTable.Rows[i]["日期"]).Month == monNow)
                    sum[monNow] += Convert.ToDouble(myTable.Rows[i]["售价"]);
                else if (Convert.ToDateTime(myTable.Rows[i]["日期"]).Month == monNow - 1)
                    sum[monNow - 1] += Convert.ToDouble(myTable.Rows[i]["售价"]);
                else if (Convert.ToDateTime(myTable.Rows[i]["日期"]).Month == monNow - 2)
                    sum[monNow - 2] += Convert.ToDouble(myTable.Rows[i]["售价"]);

            }
            chart1.Series[0].Points.AddXY(monNow - 2, sum[monNow - 2]);
            chart1.Series[0].Points.AddXY(monNow - 1, sum[monNow - 1]);
            chart1.Series[0].Points.AddXY(monNow, sum[monNow]);
            myCommand.Dispose();
            myAdapter.Dispose();                      
            myCon.Dispose();
            myCon.Close();
            

        }

        /*移动鼠标时，可显示两条线*/
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePoint = new Point(e.X, e.Y);
            chart1.ChartAreas[0].CursorX.SetCursorPixelPosition(mousePoint, true);
            chart1.ChartAreas[0].CursorY.SetCursorPixelPosition(mousePoint, true);
        }
        
        /*移动鼠标时，可显示当前点的信息*/
        private void chart1_MouseHover(object sender, EventArgs e)
        {
            if (chart1.Series.Count != 0)
            {
                for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                {
                    chart1.Series[0].Points[i].ToolTip = "#VALX"+ "月" + "," + "#VALY"+ "元" ;

                }
            }
        }
    }
}
