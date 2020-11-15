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
   
    public partial class Merchant_sys : Form
    {
        string current_zhanghao = "";
        login login_window;
        List<merchants> infolist;
        string m_id;
        public Merchant_sys(login login_window,string id)
        {
            this.login_window = login_window;
            this.current_zhanghao = id;
            InitializeComponent();
            infolist = db_Merchant.Queryable<merchants>().Where(it => it.m_identity == id).ToList();
            textBoxname.Text = infolist[0].m_name;
            textBoxcatalog.Text = infolist[0].m_catalog;
            textBoxdescribe.Text = infolist[0].m_describe;
            textBoxtel.Text = infolist[0].m_tel;
            textBoxaddress.Text = infolist[0].m_address;
            m_id = infolist[0].m_id;
        }
        public class merchants  // 名字要对应
        {
            [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
            public string m_id { get; set; }
            public string m_catalog { get; set; }
            public string m_name { get; set; }
            public string m_describe { get; set; }
            public string m_identity { get; set; }
            public string m_password { get; set; }
            public string m_tel { get; set; }
            public string m_address { get; set; }
            public string zfb { get; set; }
        }
        static SqlSugarClient db_Merchant = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "server=localhost;uid=root;pwd=12345;database=db",
            DbType = SqlSugar.DbType.MySql,//设置数据库类型
            IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
            InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
        });
       
        
        protected override void OnClosing(CancelEventArgs e)
        {
            login_window.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判定文本框内容是否为空
            if (textBoxname.Text == "" || textBoxcatalog.Text == "" || textBoxdescribe.Text == "" || textBoxtel.Text == "" || textBoxaddress.Text == "")
                MessageBox.Show("不能为空");
            else
            {
                //对数据库进行更改
                var result = db_Merchant.Updateable<merchants>(it => new merchants() { 
                    m_catalog = textBoxcatalog.Text,
                    m_name = textBoxname.Text,
                    m_describe = textBoxdescribe.Text,
                    m_tel=textBoxtel.Text,
                    m_address=textBoxaddress.Text
                }).Where(it => it.m_identity == current_zhanghao).ExecuteCommand();
                MessageBox.Show("修改成功");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBoxdescribe_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxpw1.Text == "" || textBoxpw2.Text == "")
                MessageBox.Show("输入的密码不能为空");
            else if (textBoxpw1.Text != textBoxpw2.Text)
                MessageBox.Show("两次输入的密码不一致");
            else
            {
                var result = db_Merchant.Updateable<merchants>(it => new merchants()
                {
                    m_password = textBoxpw1.Text
                }).Where(it => it.m_identity == current_zhanghao).ExecuteCommand();
                MessageBox.Show("修改成功");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            orders dish = new dishes(this, m_id);
            dish.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            orders od = new orders(this, m_id);
            od.Show();
        }
    }
}
