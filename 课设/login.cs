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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        // _______________定义user模型___________________  2020.11.14 吴远尘
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

        private void Denglu_Click(object sender, EventArgs e)
        {
            string id = id_shuru.Text;  // 获取用户输入的账号
            int option = option_list.SelectedIndex;  // 用户选择

            switch (option) 
            {
                case 0:  // 用户端
                    SqlSugarClient db_login = new SqlSugarClient(new ConnectionConfig()
                    {
                        ConnectionString = "server=localhost;uid=root;pwd=12345;database=db",
                        DbType = SqlSugar.DbType.MySql,//设置数据库类型
                        IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                        InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
                    });

                    string correct_password = "";

                        var getByWhere = db_login.Queryable<users>().Where(it => it.u_zhanghao == id).ToList();//根据条件查询
                        correct_password = getByWhere[0].u_passwd;


                    if (password_shuru.Text == correct_password)  //密码正确
                    {
                        User_sys user = new User_sys(this);  // 打开用户界面
                        this.Hide();
                        user.Show();
                    }
                    else 
                    {
                        MessageBox.Show("输入的账号或密码有误");
                    }
                    break;


            }
            
            

        }


    }
}
