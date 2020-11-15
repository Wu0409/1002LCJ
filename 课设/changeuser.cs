using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using SqlSugar;
namespace 课设
{
    public partial class changeuser : Form
    {
        public string user_id;
        public User_sys father;
        DataBase db = new DataBase();
        SqlSugarClient sqllink;
        login login_window;
        public changeuser(User_sys father,string id)
        {
            this.father = father;
            sqllink = db.db_login;
            this.user_id = id;
            InitializeComponent();
            List<users> users= sqllink.Queryable<users>().Where(it => it.u_zhanghao == user_id).ToList();
            label2.Text = users[0].u_zhanghao;
            textBox1.Text = users[0].u_name;
            textBox2.Text = users[0].u_passwd;
            textBox3.Text = users[0].u_tel;
            textBox4.Text = users[0].u_add;
            comboBox1.Text = users[0].gender;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void changeuser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox2.Text!=""&&textBox4.Text!=""&&comboBox1.Text!="")
            {
                sqllink.Updateable<users>().SetColumns(it => new users()
                {
                    u_name = textBox1.Text,
                    u_passwd = textBox2.Text,
                    u_tel=textBox3.Text,
                    u_add = textBox4.Text,
                    gender = comboBox1.Text
                }).
                Where(it => it.u_zhanghao == user_id).ExecuteCommand();
                this.Close();
            }
            else
            {
                MessageBox.Show("信息不完整");
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
