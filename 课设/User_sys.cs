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
    public partial class User_sys : Form
    {
        DataBase db = new DataBase();
        string user_id;
        SqlSugarClient sqllink;
        login login_window;
        public void insertdatagird1(List<Merchants> list)
        {
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[i].Cells[0].Value = list[i].m_name;
                this.dataGridView1.Rows[i].Cells[1].Value = list[i].m_describe;
            }

            
        }
        public User_sys(login login_window,string user_id)
        {
            // ______传入了login_window在用户端关掉时候记得最后要关掉login_window（我把login作为父窗口）_____  2020.11.14 吴远尘
            sqllink= db.db_login;
            List<Merchants> merchants = sqllink.Queryable<Merchants>().ToList();
            InitializeComponent();
            insertdatagird1(merchants);
            Image data = Image.FromFile("C:\\Users\\13105\\source\\repos\\Wu0409\\1002LCJ\\课设\\data.png");
              
            this.dataGridView1.Rows[0].Cells[2].Value=data;
            this.login_window = login_window;
            this.user_id = user_id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Merchants> merchants = sqllink.Queryable<Merchants>().Where(it => it.m_catalog == "快餐").ToList();
            insertdatagird1(merchants);
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            List<Merchants> merchants = sqllink.Queryable<Merchants>().Where(it => it.m_catalog == "中餐").ToList();
            insertdatagird1(merchants);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<Merchants> merchants = sqllink.Queryable<Merchants>().Where(it => it.m_catalog == "早餐").ToList();
            insertdatagird1(merchants);
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            List<Merchants> merchants = sqllink.Queryable<Merchants>().Where(it => it.m_catalog == "甜点").ToList();
            insertdatagird1(merchants);
        }



        protected override void OnClosing(CancelEventArgs e)
        {
            login_window.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Merchants> merchants = sqllink.Queryable<Merchants>().ToList();
            insertdatagird1(merchants);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Merchants> merchants = new List<Merchants>();
            merchants=sqllink.Queryable<Merchants>().Where(it => it.m_name.Contains(textBox1.Text)).ToList();
            insertdatagird1(merchants);
        }

        private void 修改账户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
