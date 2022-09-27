namespace filecontrol
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.dict = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.names = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paths = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.user2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.port2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ip2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lpath = new System.Windows.Forms.TextBox();
            this.fpath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ftp地址（ip）：";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(223, 38);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(286, 25);
            this.ip.TabIndex = 2;
            this.ip.Text = "10.153.88.61";
            // 
            // dict
            // 
            this.dict.Location = new System.Drawing.Point(223, 90);
            this.dict.Name = "dict";
            this.dict.Size = new System.Drawing.Size(286, 25);
            this.dict.TabIndex = 4;
            this.dict.Text = "pic\\frmQualificationMain\\2022-09-24";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ftp目录：";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(223, 145);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(286, 25);
            this.user.TabIndex = 6;
            this.user.Text = "u9012";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "用户名：";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(223, 193);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(286, 25);
            this.pass.TabIndex = 8;
            this.pass.Text = "HRLNxxb@#6789.com";
            this.pass.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "用户密码：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1082, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "下载";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // names
            // 
            this.names.Location = new System.Drawing.Point(594, 71);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(576, 25);
            this.names.TabIndex = 13;
            this.names.Text = "2171355_79850.jpg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "下载文件名：";
            // 
            // paths
            // 
            this.paths.Location = new System.Drawing.Point(594, 23);
            this.paths.Name = "paths";
            this.paths.Size = new System.Drawing.Size(576, 25);
            this.paths.TabIndex = 11;
            this.paths.Text = "download";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "下载文件路径：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.names);
            this.groupBox1.Controls.Add(this.paths);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(31, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 235);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方式一(ftp)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lpath);
            this.groupBox2.Controls.Add(this.pass2);
            this.groupBox2.Controls.Add(this.fpath);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.user2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.port2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ip2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(31, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1176, 235);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "方式二(sftp)";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1082, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "下载";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(192, 180);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(286, 25);
            this.pass2.TabIndex = 17;
            this.pass2.Text = "FIFALI1018899";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "用户密码：";
            // 
            // user2
            // 
            this.user2.Location = new System.Drawing.Point(192, 132);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(286, 25);
            this.user2.TabIndex = 15;
            this.user2.Text = "5-LIWANBING";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "用户名：";
            // 
            // port2
            // 
            this.port2.Location = new System.Drawing.Point(192, 77);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(286, 25);
            this.port2.TabIndex = 13;
            this.port2.Text = "21";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "sftp端口：";
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(192, 25);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(286, 25);
            this.ip2.TabIndex = 11;
            this.ip2.Text = "192.168.60.48";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "sftp地址（ip）：";
            // 
            // lpath
            // 
            this.lpath.Location = new System.Drawing.Point(613, 73);
            this.lpath.Name = "lpath";
            this.lpath.Size = new System.Drawing.Size(557, 25);
            this.lpath.TabIndex = 17;
            this.lpath.Text = "d:\\cjavapy.db";
            // 
            // fpath
            // 
            this.fpath.Location = new System.Drawing.Point(613, 25);
            this.fpath.Name = "fpath";
            this.fpath.Size = new System.Drawing.Size(557, 25);
            this.fpath.TabIndex = 15;
            this.fpath.Text = "/home/admin/cjavapy.db";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(484, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "本地文件路径：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "服务器文件路径：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dict);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "海典ftp测试（linux）";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox dict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paths;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox lpath;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.TextBox fpath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox user2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox port2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ip2;
        private System.Windows.Forms.Label label10;
    }
}

