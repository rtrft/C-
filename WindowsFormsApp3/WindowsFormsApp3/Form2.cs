using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public bool checkuser(string name, string passwd)
        {
            bool result = false;
            string constring = "Server=desktop-add3gv7;Database=GOODS;Integrated Security=SSPI";
            string sql1 = string.Format("select*from user1 where name='{0}'and passwd='{1}'", name, passwd);
            string sql2 = string.Format("select*from user2 where name='{0}'and passwd='{1}'", name, passwd);
            string sql=sql1;
            if (comboBox1.Text.Equals("店员"))
                sql = sql1;  
            
            else if (comboBox1.Text.Equals("管理者"))
                    sql = sql2;
            else
                MessageBox.Show("你还未选择身份，请选择后登陆！");
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = conn;
            cmm.CommandText = sql;
            cmm.CommandType = CommandType.Text;
            object re = cmm.ExecuteScalar();
            if (re != null)
            { result = true; }
            else
            { result = false; }
            return result;
        }

        public bool checkuser1(string name, string passwd)
        {
            bool result = false;
            string constring = "Server=desktop-add3gv7;Database=GOODS;Integrated Security=SSPI";
            string sql1 = string.Format("insert into user1(name,passwd) values('{0}','{1}')", name,passwd);
            string sql2 = string.Format("insert into user1(name,passwd) values('{0}','{1}')", name, passwd);
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = conn;
            int rows=0;
            if (comboBox1.Text.Equals("店员"))
            {
                cmm.CommandText = sql1;
                cmm.CommandType = CommandType.Text;
                rows = cmm.ExecuteNonQuery();
            }
            else if (comboBox1.Text.Equals("管理者"))
            {
                cmm.CommandText = sql2;
                cmm.CommandType = CommandType.Text;
                rows = cmm.ExecuteNonQuery();
            }
            else
                MessageBox.Show("你还未选择身份，请选择后注册！");
            if (rows > 0)
            { MessageBox.Show("注册成功！"); }
            else
            { MessageBox.Show("注册失败！"); }
            return result;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkuser(textBox1.Text, textBox2.Text) == true&& comboBox1.Text.Equals("店员"))
            {
                MessageBox.Show("登录成功！");
                this.Hide();
                Form3 mainFrom = new Form3();
                mainFrom.ShowDialog();
            }
            else if(checkuser(textBox1.Text, textBox2.Text) == true && comboBox1.Text.Equals("管理者"))
            {
                MessageBox.Show("登录成功！");
                this.Hide();
                Form5 mainFrom = new Form5();
                mainFrom.ShowDialog();
            }
            else
                MessageBox.Show("用户名或密码错误，登录失败！");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text== string.Empty||textBox2.Text==string.Empty)
            {
                MessageBox.Show("用户名或者密码为空！请重新输入！","注册提示");
                return;
            }
            else
            {
                checkuser1(textBox1.Text, textBox2.Text);
            }
            
        }
    }

}