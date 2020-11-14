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
        [SugarTable("user")]
        public class Usermodel
        {
            //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
            [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
            public string id { get; set; }
            public string password { get; set; }
        }

        private void Denglu_Click(object sender, EventArgs e)
        {
            string id = id_shuru.Text;  // 获取用户输入的账号

            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "server=localhost;uid=root;pwd=1234567890;database=db",
                DbType = SqlSugar.DbType.MySql,//设置数据库类型
                IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
            });

            var getByWhere = db.Queryable<Usermodel>().Where(it => it.id == id).ToList();//根据条件查询
            
            MessageBox.Show(getByWhere[0].password);
            

        }


    }
}
