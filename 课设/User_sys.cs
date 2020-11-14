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
    public partial class User_sys : Form
    {
        login login_window;
        public User_sys(login login_window)
        {
            // ______传入了login_window在用户端关掉时候记得最后要关掉login_window（我把login作为父窗口）_____  2020.11.14 吴远尘
            this.login_window = login_window;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            login_window.Close();
        }
        
    }
}
