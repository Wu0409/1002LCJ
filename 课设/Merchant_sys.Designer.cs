
namespace 课设
{
    partial class Merchant_sys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxcatalog = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxdescribe = new System.Windows.Forms.TextBox();
            this.textBoxtel = new System.Windows.Forms.TextBox();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.textBoxpw1 = new System.Windows.Forms.TextBox();
            this.textBoxpw2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "修改信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxcatalog
            // 
            this.textBoxcatalog.Location = new System.Drawing.Point(12, 12);
            this.textBoxcatalog.Name = "textBoxcatalog";
            this.textBoxcatalog.Size = new System.Drawing.Size(188, 21);
            this.textBoxcatalog.TabIndex = 1;
            this.textBoxcatalog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxname
            // 
            this.textBoxname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxname.Location = new System.Drawing.Point(12, 39);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(188, 21);
            this.textBoxname.TabIndex = 2;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxdescribe
            // 
            this.textBoxdescribe.Location = new System.Drawing.Point(12, 70);
            this.textBoxdescribe.Multiline = true;
            this.textBoxdescribe.Name = "textBoxdescribe";
            this.textBoxdescribe.Size = new System.Drawing.Size(188, 97);
            this.textBoxdescribe.TabIndex = 3;
            this.textBoxdescribe.TextChanged += new System.EventHandler(this.textBoxdescribe_TextChanged);
            // 
            // textBoxtel
            // 
            this.textBoxtel.Location = new System.Drawing.Point(250, 65);
            this.textBoxtel.Name = "textBoxtel";
            this.textBoxtel.Size = new System.Drawing.Size(251, 21);
            this.textBoxtel.TabIndex = 4;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(250, 92);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(251, 21);
            this.textBoxaddress.TabIndex = 5;
            // 
            // textBoxpw1
            // 
            this.textBoxpw1.Location = new System.Drawing.Point(12, 217);
            this.textBoxpw1.Name = "textBoxpw1";
            this.textBoxpw1.Size = new System.Drawing.Size(188, 21);
            this.textBoxpw1.TabIndex = 6;
            // 
            // textBoxpw2
            // 
            this.textBoxpw2.Location = new System.Drawing.Point(12, 244);
            this.textBoxpw2.Name = "textBoxpw2";
            this.textBoxpw2.Size = new System.Drawing.Size(188, 21);
            this.textBoxpw2.TabIndex = 7;
            this.textBoxpw2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "修改密码";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "查看菜品";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "查看订单";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Merchant_sys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxpw2);
            this.Controls.Add(this.textBoxpw1);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(this.textBoxtel);
            this.Controls.Add(this.textBoxdescribe);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxcatalog);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Merchant_sys";
            this.Text = "Merchant_sys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBoxcatalog;
        public System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxdescribe;
        private System.Windows.Forms.TextBox textBoxtel;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.TextBox textBoxpw1;
        private System.Windows.Forms.TextBox textBoxpw2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}