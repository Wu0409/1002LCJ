using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课设
{
    public partial class register_merchant : Form
    {
        login login_window;
        string current_id;
        public register_merchant(login login_window,string id)
        {
            this.login_window = login_window;
            this.current_id = id;
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            login_window.Close();
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
        private void button1_Click(object sender, EventArgs e)
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "server=localhost;uid=root;pwd=12345;database=db",
                DbType = SqlSugar.DbType.MySql,//设置数据库类型
                IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
            });

            var result = db.Updateable<merchants>().SetColumns(it => it.m_catalog == comboBox1.SelectedItem)
                .Where(it => it.m_id == current_id)
                .ExecuteCommand();
            var result1 = db.Updateable<merchants>().SetColumns(it => it.m_name == textBox1.Text)
                .Where(it => it.m_id == current_id)
                .ExecuteCommand();
            var result2 = db.Updateable<merchants>().SetColumns(it => it.m_address == textBox2.Text)
                .Where(it => it.m_id == current_id)
                .ExecuteCommand();
            var result3 = db.Updateable<merchants>().SetColumns(it => it.m_describe == textBox3.Text)
                .Where(it => it.m_id == current_id)
                .ExecuteCommand();

            this.Hide();
            Merchant_sys merchant = new Merchant_sys(login_window,current_id);
            merchant.Show();
            this.Hide();
        }
    }
}
