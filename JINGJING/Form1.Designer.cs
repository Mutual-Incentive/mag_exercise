namespace JINGJING
{
    partial class main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_ok = new System.Windows.Forms.Button();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.label_tettle = new System.Windows.Forms.Label();
            this.comboBox_Baud_rate = new System.Windows.Forms.ComboBox();
            this.label_selet_port = new System.Windows.Forms.Label();
            this.comboBox_select_port = new System.Windows.Forms.ComboBox();
            this.label_Baud_rate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(121, 165);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(173, 104);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(121, 99);
            this.textbox_password.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(171, 28);
            this.textbox_password.TabIndex = 2;
            this.textbox_password.TextChanged += new System.EventHandler(this.textbox_password_TextChanged);
            // 
            // label_tettle
            // 
            this.label_tettle.AutoSize = true;
            this.label_tettle.Location = new System.Drawing.Point(150, 68);
            this.label_tettle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tettle.Name = "label_tettle";
            this.label_tettle.Size = new System.Drawing.Size(107, 18);
            this.label_tettle.TabIndex = 3;
            this.label_tettle.Text = "Pass   Word";
            this.label_tettle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox_Baud_rate
            // 
            this.comboBox_Baud_rate.FormattingEnabled = true;
            this.comboBox_Baud_rate.Location = new System.Drawing.Point(183, 124);
            this.comboBox_Baud_rate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Baud_rate.Name = "comboBox_Baud_rate";
            this.comboBox_Baud_rate.Size = new System.Drawing.Size(180, 26);
            this.comboBox_Baud_rate.TabIndex = 5;
            this.comboBox_Baud_rate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_selet_port
            // 
            this.label_selet_port.AutoSize = true;
            this.label_selet_port.Location = new System.Drawing.Point(30, 65);
            this.label_selet_port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_selet_port.Name = "label_selet_port";
            this.label_selet_port.Size = new System.Drawing.Size(107, 18);
            this.label_selet_port.TabIndex = 6;
            this.label_selet_port.Text = "Serial Port";
            this.label_selet_port.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // comboBox_select_port
            // 
            this.comboBox_select_port.FormattingEnabled = true;
            this.comboBox_select_port.Location = new System.Drawing.Point(183, 62);
            this.comboBox_select_port.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_select_port.Name = "comboBox_select_port";
            this.comboBox_select_port.Size = new System.Drawing.Size(180, 26);
            this.comboBox_select_port.TabIndex = 7;
            this.comboBox_select_port.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label_Baud_rate
            // 
            this.label_Baud_rate.AutoSize = true;
            this.label_Baud_rate.Location = new System.Drawing.Point(48, 132);
            this.label_Baud_rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Baud_rate.Name = "label_Baud_rate";
            this.label_Baud_rate.Size = new System.Drawing.Size(89, 18);
            this.label_Baud_rate.TabIndex = 8;
            this.label_Baud_rate.Text = "Baud Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_tettle);
            this.groupBox1.Controls.Add(this.button_ok);
            this.groupBox1.Controls.Add(this.textbox_password);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 326);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_select_port);
            this.groupBox2.Controls.Add(this.comboBox_Baud_rate);
            this.groupBox2.Controls.Add(this.label_selet_port);
            this.groupBox2.Controls.Add(this.label_Baud_rate);
            this.groupBox2.Location = new System.Drawing.Point(504, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 231);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 664);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "main";
            this.Text = "JJ";
            this.Load += new System.EventHandler(this.主界面_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Label label_tettle;
        private System.Windows.Forms.ComboBox comboBox_Baud_rate;
        private System.Windows.Forms.Label label_selet_port;
        private System.Windows.Forms.ComboBox comboBox_select_port;
        private System.Windows.Forms.Label label_Baud_rate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

