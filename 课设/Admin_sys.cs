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
    public partial class Admin_sys : Form
    {
        login login_window;
        public Admin_sys(login login_window)
        {
            this.login_window = login_window;
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            login_window.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
