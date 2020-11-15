using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data;
using System.Windows.Forms;

namespace 课设
{
    public partial class register : Form
    {
        private int option = 0; // 判断是哪一个端注册
        public login login_window;
        string yan;  // 验证码
        private string code;  // 短信验证码

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
        public register(int option, login login_window)
        {
            this.login_window = login_window;
            this.option = option;
            InitializeComponent();
            switch (this.option)
            {
                case 0:  // 用户注册
                    title.Text = "用户注册";
                    break;
                case 1:  // 商家注册
                    title.Text = "商家注册";
                    break;
            }

            // 手机号验证前的二维码
            yan = "";
            string a = "1234567890";
            Random random = new Random();
            //循环六次得到一个随机的六位的验证码
            for (int i = 0; i < 4; i++)
            {
                yan = yan + a.Substring(random.Next(0, a.Length), 1);
            }
            yanzheng.Text = yan;
        }
        protected override void OnClosing(CancelEventArgs e)  // 关闭该页面，重新打开登录
        {
            login_window.Show();
            this.Hide();
        }
        private void cancel_Click_1(object sender, EventArgs e)  // 取消键
        {
            login_window.Show();
            this.Hide();
        }

        int elapse_time = 60;  // 设计一个倒计时
        bool tag = true;
        System.Timers.Timer t = new System.Timers.Timer();//实例化Timer类
        private void timeinit()
        {
            int intTime = 1000;

            t.Interval = intTime;//设置间隔时间，为毫秒；
            t.Elapsed += new System.Timers.ElapsedEventHandler(theout);//到达时间的时候执行事件；
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
        }
        private void theout(object sender, EventArgs e)
        {
            if (elapse_time != 0)
            {
                elapse_time -= 1;
                
                button1.Invoke(new EventHandler(delegate
                {
                    button1.Text = elapse_time.ToString() + "s后获取";
                }));
            }
            else 
            {
                button1.Text = "获取短信验证";
                t.Stop();
                elapse_time = 60; // 重新初始化
                tag = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)  // 获取短信验证码
        {
            if (tag)  // 说明没有处于倒计时
            {
                if (textBox4.Text == yan)
                {
                    SMSPhone sms = new SMSPhone();
                    string phone_number = textBox2.Text;
                    string pattern = "^1[3|4|5|7|8][0-9]{9}$";
                    Match m = Regex.Match(phone_number, pattern);  // 判断是否符合手机号
                    if (m.Success)
                    {
                        // code = sms.getSMSCode(phone_number);
                        button1.Text = "60s后获取";
                        timeinit();
                        t.Start();
                        tag = false;
                    }
                    else
                    {
                        MessageBox.Show("请输入正确的手机号");
                    }
                }
                else
                {
                    MessageBox.Show("输入的验证码不符！\n请重新输入");
                }
            }  
        }

        private void zhuce_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && (mima1.Text != "") && (mima1.Text == mima2.Text))  // textBox3.Text == code
            {
                switch (option)
                {
                    case 0:
                        SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
                        {
                            ConnectionString = "server=localhost;uid=root;pwd=12345;database=db",
                            DbType = SqlSugar.DbType.MySql,//设置数据库类型
                            IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                            InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
                        });
                        var isAny = db.Queryable<users>().Where(it => it.u_zhanghao == textBox1.Text).Any();  //是否存在
                        if (isAny)
                        {
                            MessageBox.Show("用户已存在！\n请更换注册账号名");
                        }
                        else // 用户不存在，添加至数据库
                        {
                            string a = "1234567890";
                            string create_tmp_name = "";
                            string create_id = "";
                            Random random = new Random();
                            // 获得初始账号和id
                            for (int i = 0; i < 4; i++)
                            {
                                create_tmp_name = create_tmp_name + a.Substring(random.Next(0, a.Length), 1);
                                create_id = create_id + a.Substring(random.Next(0, a.Length), 1);

                            }

                            users add = new users();
                            add.u_zhanghao = textBox1.Text;
                            add.u_passwd = mima1.Text;
                            add.u_name = "你饿吗用户" + create_tmp_name;
                            add.u_id = create_id;
                            add.u_tel = textBox2.Text;
                            db.Insertable(add).ExecuteCommand();
                            MessageBox.Show("账号注册成功！");
                            this.Hide();
                            login_window.Show();
                        }
                        break;
                }
            }
        }

        private void yanzheng_Click(object sender, EventArgs e)
        {
            yan = "";
            string a = "1234567890";
            Random random = new Random();
            //循环六次得到一个随机的六位的验证码
            for (int i = 0; i < 4; i++)
            {
                yan = yan + a.Substring(random.Next(0, a.Length), 1);
            }
            yanzheng.Text = yan;
        }

        
    }
    public class SMSPhone
    {
        //存放验证码
        string yzm = "";
        string a = "1234567890";//用于生成随机验证码的源

        private string url = "http://106.ihuyi.com/webservice/sms.php?";//接口地址
        private string strUid = "C69403975";//用户ID
        private string strKey = "7e51a0dfd3ce1ac645539b4729e3cbf7"; //开发者密钥，用于和用户ID配合去调用接口
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public string getSMSCode(string phone)
        {
            //生成验证码

            //实例化一个随机数
            Random random = new Random();
            //循环六次得到一个随机的六位的验证码
            for (int i = 0; i < 6; i++)
            {
                yzm = yzm + a.Substring(random.Next(0, a.Length), 1);
            }

            //判断手机号是否为空
            if (phone.Trim() != "")
            {
            //需要调用的链接和发送的内容
                url = "http://106.ihuyi.com/webservice/sms.php?method=Submit&account=" + strUid + "&password=" + strKey + "&mobile=" + phone + "&content=" + "您的验证码是：" + yzm + "。请不要把验证码泄露给其他人。";
                //调用请求接口的方法
                string Result = GetHtmlFromUrl(url);
                //判断是否发送成功
                MessageBox.Show("验证码已发送！");
            }
            return yzm;
        }
        /// <summary>
        /// get方式请求http接口
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <returns></returns>
        public string GetHtmlFromUrl(string url)
        {
            string strRet = null;
            //判断链接是否为空或者null
            if (url == null || url.Trim().ToString() == "")
            {
                return strRet;
            }
            //定义目标链接
            string targeturl = url.Trim().ToString();
            try
            {
                //http的特定实现，用于访问http接口
                HttpWebRequest hr = (HttpWebRequest)WebRequest.Create(targeturl);
                hr.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
                //设置请求方法
                hr.Method = "GET";
                //验证码的有效时间30分钟
                hr.Timeout = 30 * 60 * 1000;
                WebResponse hs = hr.GetResponse();
                Stream sr = hs.GetResponseStream();
                StreamReader ser = new StreamReader(sr, Encoding.UTF8);
                strRet = ser.ReadToEnd();
            }
            catch (Exception)
            {
                strRet = null;
            }
            return strRet;
        }
    }
}
