using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Goods g = new Goods();

        public SqlDataReader GetGoodID(string where)
        {
            string constring = "Server=desktop-add3gv7;Database=GOODS;Integrated Security=SSPI";
            string sql1 = "select * from goods1" + where;
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmm = new SqlCommand(sql1, conn);
            SqlDataReader dr = cmm.ExecuteReader();
            return dr;
        }

        public void Enquiry()
        {
            g.goodName =txtgoodname.Text;
            string where = " where goodName='" + g.goodName + "'";
            SqlDataReader dr = GetGoodID(where);
            if (dr.HasRows)
            {
                dr.Read();
                txtgoodname.Text = dr["goodName"].ToString();
                txtgoodinprice.Text= dr["Inprice"].ToString();
                txtgoodOutPrice.Text = dr["Outprice"].ToString();
                txtgoodcount.Text = dr["Inventory"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sum = (Convert.ToInt32(txtgoodOutPrice.Text.Replace(" ", "")) - Convert.ToInt32(txtgoodinprice.Text.Replace(" ", "")))* Convert.ToInt32(txtgoodsales.Text.Replace(" ", ""));
            int con = Convert.ToInt32(txtgoodcount.Text.Replace(" ", "")) - Convert.ToInt32(txtgoodsales.Text.Replace(" ", ""));
            txtgoodprofit.Text= sum.ToString();
            string sqlStr = "Update goods1 Set Inventory=@Inventory where goodName=@gName";
            Helper help = new Helper();
            SqlParameter[] param =
            {
                new SqlParameter("@gName",txtgoodname.Text),
                new SqlParameter("@Inventory",con.ToString()),
            };
            if (help.Excute(sqlStr, param) > 0)
            {
                MessageBox.Show("售卖成功");
            }
            else
            {
                MessageBox.Show("售卖失败！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtgoodOutPrice.ReadOnly = true;
            txtgoodcount.ReadOnly = true;
            txtgoodprofit.ReadOnly = true;
            Enquiry();
        }
    }
}
