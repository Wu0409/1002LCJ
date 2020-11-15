using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using SqlSugar;

namespace 课设
{
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

    public class Merchants  // 名字要对应
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
    public class dishes  // 表的名字
    {
        //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string dh_id { get; set; }
        public string dh_catelog { get; set; }
        public string dh_name { get; set; }
        public string dh_descri { get; set; }
        public string price { get; set; }  // 名字要对应
        public string pic { get; set; }
        public string m_id { get; set; }
    }

    public class corrs  // 表的名字
    {
        //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string corr_id { get; set; }
        public string order_id { get; set; }
        public int dish_num { get; set; }
        public string dish_id { get; set; }
    }
    public class orders  // 表的名字
    {
        //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string order_id { get; set; }
        public string order_time { get; set; }
        public string order_addre { get; set; }
        public string order_statu { get; set; }
        public string order_grade { get; set; }  // 名字要对应
        public string user_id { get; set; }
    }
    public class DataBase
    {
        public SqlSugarClient db_login;
        
        public DataBase()
        {
            db_login = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "server=localhost;uid=root;pwd=12345;database=db",
                DbType = SqlSugar.DbType.MySql,//设置数据库类型
                IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
            });
        }
        public List<users> GetUserByID(string id)
        {
            var getUsers = db_login.Queryable<users>().Where(it => it.u_zhanghao == id).ToList();//根据条件查询
            return getUsers;
        }
        public List<Merchants> GetMerchantsByID(string id)
        {
            var getmerchants = db_login.Queryable<Merchants>().Where(it => it.m_id == id).ToList();//根据条件查询
            return getmerchants;
        }
        public List<dishes> GetDishesByID(string id)
        {
            var getDishes = db_login.Queryable<dishes>().Where(it => it.dh_id== id).ToList();//根据条件查询
            return getDishes;
        }
    }
}
