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

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            DataBind2();
        }

        public void DataBind2()//查找
        {
            User1 u = new User1();
            u.name = txtuserName.Text;
            u.passwd = txtuserPasswd.Text;
            string sqlStr = "select * from user1 where 1=1";
            sqlStr += u.name == "" ? "" : "and name='" + u.name + " ' ";
            sqlStr += u.passwd == "" ? "" : "and passwd=" + u.passwd;
            Helper help = new Helper();
            DataSet ds = help.GetData(sqlStr);
            if (ds == null)
            {
                MessageBox.Show("");
            }
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.user1View.DataSource = ds.Tables[0];
            }
            else
            {
                this.user1View.DataSource = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//查
        {
            DataBind2();
        }

        private void button2_Click_1(object sender, EventArgs e)//修改
        {
            User1 u = new User1();
            u.name = txtuserName.Text;
            u.passwd = txtuserPasswd.Text;
            string sqlStr = "Update user1 Set passwd=@userPasswd where name=@userName";
            SqlParameter[] param =
            {
                new SqlParameter("@userName",u.name),
                new SqlParameter("@userPasswd",u.passwd),
            };
            Helper help = new Helper();
            if (help.Excute(sqlStr, param) > 0)
            {
                MessageBox.Show("修改成功");
                DataBind2();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)//添加
        {
            User1 u = new User1();
            u.name = txtuserName.Text;
            u.passwd = txtuserPasswd.Text;
            string sqlStr = "insert into user1(name,passwd)" + "values(@userName,@userPasswd)";
            SqlParameter[] param =
            {
                new SqlParameter("@userName",u.name),
                new SqlParameter("@userPasswd",u.passwd),
            };
            Helper help = new Helper();
            if (help.Excute(sqlStr, param) > 0)
            {
                MessageBox.Show("添加成功");
                DataBind2();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)//删除
        {
            User1 u = new User1();
            u.name = txtuserName.Text;
            string sqlStr = "Delete from user1 where name='" + u.name + "'";
            Helper help = new Helper();
            if (help.Excute(sqlStr) > 0)
            {
                MessageBox.Show("删除成功");
                DataBind2();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            txtuserName.Text = "";
            txtuserPasswd.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void user1View_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtuserName.Text = user1View.Rows[rowIndex].Cells[0].Value.ToString();
            txtuserPasswd.Text = user1View.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
