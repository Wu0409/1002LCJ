﻿
namespace 课设
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.id_shuru = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.password_shuru = new System.Windows.Forms.TextBox();
            this.Denglu = new System.Windows.Forms.Button();
            this.Zhuce = new System.Windows.Forms.Button();
            this.option_list = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(44, 23);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(175, 25);
            this.title.TabIndex = 0;
            this.title.Text = "订单管理系统 1.0.0";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ID.Location = new System.Drawing.Point(45, 107);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(58, 21);
            this.ID.TabIndex = 2;
            this.ID.Text = "账号：";
            // 
            // id_shuru
            // 
            this.id_shuru.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.id_shuru.Location = new System.Drawing.Point(47, 131);
            this.id_shuru.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_shuru.Name = "id_shuru";
            this.id_shuru.Size = new System.Drawing.Size(161, 29);
            this.id_shuru.TabIndex = 3;
            this.id_shuru.TextChanged += new System.EventHandler(this.id_shuru_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(45, 169);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(58, 21);
            this.password.TabIndex = 4;
            this.password.Text = "密码：";
            // 
            // password_shuru
            // 
            this.password_shuru.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_shuru.Location = new System.Drawing.Point(47, 193);
            this.password_shuru.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_shuru.Name = "password_shuru";
            this.password_shuru.Size = new System.Drawing.Size(161, 29);
            this.password_shuru.TabIndex = 5;
            this.password_shuru.UseSystemPasswordChar = true;
            // 
            // Denglu
            // 
            this.Denglu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Denglu.Location = new System.Drawing.Point(47, 241);
            this.Denglu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Denglu.Name = "Denglu";
            this.Denglu.Size = new System.Drawing.Size(64, 28);
            this.Denglu.TabIndex = 6;
            this.Denglu.Text = "登录";
            this.Denglu.UseVisualStyleBackColor = true;
            this.Denglu.Click += new System.EventHandler(this.Denglu_Click);
            // 
            // Zhuce
            // 
            this.Zhuce.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Zhuce.Location = new System.Drawing.Point(143, 241);
            this.Zhuce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Zhuce.Name = "Zhuce";
            this.Zhuce.Size = new System.Drawing.Size(64, 28);
            this.Zhuce.TabIndex = 7;
            this.Zhuce.Text = "注册";
            this.Zhuce.UseVisualStyleBackColor = true;
            // 
            // option_list
            // 
            this.option_list.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.option_list.FormattingEnabled = true;
            this.option_list.Items.AddRange(new object[] {
            "用户端",
            "商家端",
            "客户端"});
            this.option_list.Location = new System.Drawing.Point(47, 66);
            this.option_list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.option_list.Name = "option_list";
            this.option_list.Size = new System.Drawing.Size(159, 29);
            this.option_list.TabIndex = 8;
            this.option_list.Text = "用户端";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 319);
            this.Controls.Add(this.option_list);
            this.Controls.Add(this.Zhuce);
            this.Controls.Add(this.Denglu);
            this.Controls.Add(this.password_shuru);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id_shuru);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox id_shuru;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox password_shuru;
        private System.Windows.Forms.Button Denglu;
        private System.Windows.Forms.Button Zhuce;
        private System.Windows.Forms.ComboBox option_list;
    }
}

