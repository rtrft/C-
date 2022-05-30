using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void add1()
        {

            Goods g = new Goods();
            g.goodID = txtGoodsID.Text;
            g.goodName = txtGoodsName.Text;
            g.inPrice = txtGoodsInPrice.Text;
            g.outPrice = txtGoodsOutPrice.Text;
            g.count = txtgoodscount.Text;
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
            if (help.Excute(sqlStr, param) > 0)
            {
                MessageBox.Show("进货成功");
            }
            else
            {
                MessageBox.Show("进货失败！");
            }
          
        }

        public SqlDataReader GetGoodID(string where)
        {
            string constring= "Server=desktop-add3gv7;Database=GOODS;Integrated Security=SSPI";
            string sql1 = "select * from goods1" + where;
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmm = new SqlCommand(sql1, conn);
            SqlDataReader dr = cmm.ExecuteReader() ;
            return dr;
        }



        public void add2()
        {
            Goods g = new Goods();
            g.goodID = txtGoodsID.Text;
            int sum = Convert.ToInt32(txtGoodsInventory.Text.Replace(" ", "")) + Convert.ToInt32(txtgoodscount.Text.Replace(" ", ""));
            string sumInventory= sum.ToString();
            string sqlStr = "Update goods1 Set Inventory=@Inventory where goodsID=@gID";
            Helper help = new Helper();
            SqlParameter[] param =
            {
                new SqlParameter("@gID",g.goodID),
                new SqlParameter("@Inventory",sumInventory),
            };
            if (help.Excute(sqlStr, param) > 0)
            {
                MessageBox.Show("进货成功");
            }
            else
            {
                MessageBox.Show("进货失败！");
            }
        }


        public void Enquiry()
        {
            Goods g = new Goods();
            g.goodID = txtGoodsID.Text;
            string where = " where goodsID='" + g.goodID + "'";
            SqlDataReader dr = GetGoodID(where);
            if (dr.HasRows)
            {
                dr.Read();
                txtGoodsName.Text = dr["goodName"].ToString();
                txtGoodsInPrice.Text = dr["Inprice"].ToString();
                txtGoodsOutPrice.Text = dr["Outprice"].ToString();
                txtGoodsInventory.Text = dr["Inventory"].ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
         {
            if(comboBox1.Text.Equals("已有商品"))
            {
                add2();
            }
            else if (comboBox1.Text.Equals("新商品"))
            {
                add1();
            }
            else
            {
                MessageBox.Show("请选择商品类别！");
            }
         }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text.Equals("已有商品"))
            {
                Enquiry();
            }
            else if (comboBox1.Text.Equals("新商品"))
            {
                MessageBox.Show("商品不存在");
            }
            else
            {
                MessageBox.Show("请选择商品类别！");
            }
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGoodsID.Text = "";
            txtGoodsName.Text = "";
            txtGoodsInPrice.Text = "";
            txtGoodsOutPrice.Text = "";
            txtGoodsInventory.Text = "";
            txtgoodscount.Text = "";
            if (comboBox1.Text.Equals("已有商品"))
            {
                txtGoodsName.ReadOnly = true;
                txtGoodsInPrice.ReadOnly = true;
                txtGoodsOutPrice.ReadOnly = true;
                txtGoodsInventory.ReadOnly = true;
                txtgoodscount.Text = "";
            }
            else if (comboBox1.Text.Equals("新商品"))
            {
                txtGoodsName.ReadOnly = false;
                txtGoodsInPrice.ReadOnly = false;
                txtGoodsOutPrice.ReadOnly = false;
                txtGoodsInventory.ReadOnly = true;
                txtGoodsID.Text = "";
                txtGoodsName.Text = "";
                txtGoodsInPrice.Text = "";
                txtGoodsOutPrice.Text = "";
                txtGoodsInventory.Text = "";
                txtgoodscount.Text = "";
                txtGoodsID.Focus();
            }
            else
            {
                MessageBox.Show("请选择商品类别！");
            }
        }
    }
}
