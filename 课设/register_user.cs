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
    public partial class register_user : Form
    {
        login login_window;
        string current_id;
        public register_user(login login_window,string user_id)
        {
            this.login_window = login_window;
            this.current_id = user_id;
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            login_window.Close();
        }
        public class users  // 表的名字
        {
            //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
            [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
            public string u_id { get; set; }
            public string u_name { get; set; }
            public string u_zhanghao { get; set; }
            public string u_passwd { get; set; }
            public string u_tel { get; set; }  // 名字要对应
            public string u_add { get; set; }
            public string gender { get; set; }
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

            var result = db.Updateable<users>().SetColumns(it => it.u_add == textBox1.Text)
                .Where(it => it.u_id == current_id)
                .ExecuteCommand();
            var result1 = db.Updateable<users>().SetColumns(it => it.gender == comboBox1.SelectedItem.ToString())
                .Where(it => it.u_id == current_id)
                .ExecuteCommand();

            this.Hide();
            User_sys user = new User_sys(login_window,current_id);
            user.Show();
            this.Hide();

        }
    }
}
