using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            Goods g = new Goods();
            g.goodID= txtGoodsID.Text;
            g.goodName= txtGoodsName.Text;
            g.inPrice = txtGoodsInPrice.Text;
            g.outPrice = txtGoodsOutPrice.Text;
            string sqlStr = "select * from goods1 where 1=1";
            sqlStr += g.goodID == ""? "" : "and GoodsID='" + g.goodID+ " ' ";
            sqlStr += g.goodName == ""? "" : "and goodName like'%" + g.goodName + "%' ";
            sqlStr += g.inPrice == ""? "" : "and Inprice=" + g.inPrice;
            sqlStr += g.outPrice == ""? "" : "and Outprice=" + g.outPrice;
            Helper help = new Helper();
            DataSet ds = help.GetData(sqlStr);
            if (ds == null)
            {
                MessageBox.Show("");
            }
            if (ds!=null&&ds.Tables[0].Rows.Count>0)
            {
                this.goodsView.DataSource = ds.Tables[0];
            }
            else
            {
                this.goodsView.DataSource = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             DataBind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Goods g = new Goods();
            g.goodID= txtGoodsID.Text;
            g.goodName = txtGoodsName.Text;
            g.inPrice= txtGoodsInPrice.Text;
            g.outPrice= txtGoodsOutPrice.Text;
            g.count= txtGoodsInventory.Text;
            string sqlStr = "insert into goods1(GoodsID,goodName,Inprice,Outprice,Inventory)" + "values(@gID,@Name,@Inprice,@outprice,@Inventory)";
            SqlParameter[] param =
            {
                new SqlParameter("@gID",g.goodID),
                new SqlParameter("@Name",g.goodName),
                new SqlParameter("@Inprice",g.inPrice),
                new SqlParameter("@outprice",g.outPrice),
                new SqlParameter("@Inventory",g.count),
            };
            Helper help = new Helper();
            if(help.Excute(sqlStr,param)>0)
            {
                MessageBox.Show("添加成功");
                DataBind();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goods g = new Goods();
            g.goodID = txtGoodsID.Text;
            g.goodName = txtGoodsName.Text;
            g.inPrice = txtGoodsInPrice.Text;
            g.outPrice = txtGoodsOutPrice.Text;
            g.count = txtGoodsInventory.Text;
            string sqlStr = "Update goods1 Set goodName=@Name,Inprice=@Inprice,Outprice=@Outprice," + "Inventory=@Inventory where goodsID=@gID";
            SqlParameter[] param =
            {
                new SqlParameter("@gID",g.goodID),
                new SqlParameter("@Name",g.goodName),
                new SqlParameter("@Inprice",g.inPrice),
                new SqlParameter("@outprice",g.outPrice),
                new SqlParameter("@Inventory",g.count),
            };
            Helper help = new Helper();
            if (help.Excute(sqlStr, param) > 0)
            {
                MessageBox.Show("修改成功");
                DataBind();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Goods g = new Goods();
            g.goodID = txtGoodsID.Text;
            string sqlStr = "Delete from goods1 where goodsID='" + g.goodID + "'";
            Helper help = new Helper();
            if (help.Excute(sqlStr) > 0)
            {
                MessageBox.Show("删除成功");
                DataBind();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void goodsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtGoodsID.Text = goodsView.Rows[rowIndex].Cells[0].Value.ToString();
            txtGoodsName.Text = goodsView.Rows[rowIndex].Cells[1].Value.ToString();
            txtGoodsInPrice.Text = goodsView.Rows[rowIndex].Cells[2].Value.ToString();
            txtGoodsOutPrice.Text = goodsView.Rows[rowIndex].Cells[3].Value.ToString();
            txtGoodsInventory.Text = goodsView.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
