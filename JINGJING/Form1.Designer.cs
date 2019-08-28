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
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(94, 153);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(184, 69);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(94, 109);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(184, 21);
            this.textbox_password.TabIndex = 2;
            this.textbox_password.TextChanged += new System.EventHandler(this.textbox_password_TextChanged);
            // 
            // label_tettle
            // 
            this.label_tettle.AutoSize = true;
            this.label_tettle.Location = new System.Drawing.Point(145, 83);
            this.label_tettle.Name = "label_tettle";
            this.label_tettle.Size = new System.Drawing.Size(71, 12);
            this.label_tettle.TabIndex = 3;
            this.label_tettle.Text = "Pass   Word";
            this.label_tettle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox_Baud_rate
            // 
            this.comboBox_Baud_rate.FormattingEnabled = true;
            this.comboBox_Baud_rate.Location = new System.Drawing.Point(368, 202);
            this.comboBox_Baud_rate.Name = "comboBox_Baud_rate";
            this.comboBox_Baud_rate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Baud_rate.TabIndex = 5;
            this.comboBox_Baud_rate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_selet_port
            // 
            this.label_selet_port.AutoSize = true;
            this.label_selet_port.Location = new System.Drawing.Point(388, 83);
            this.label_selet_port.Name = "label_selet_port";
            this.label_selet_port.Size = new System.Drawing.Size(71, 12);
            this.label_selet_port.TabIndex = 6;
            this.label_selet_port.Text = "Serial Port";
            this.label_selet_port.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // comboBox_select_port
            // 
            this.comboBox_select_port.FormattingEnabled = true;
            this.comboBox_select_port.Location = new System.Drawing.Point(368, 110);
            this.comboBox_select_port.Name = "comboBox_select_port";
            this.comboBox_select_port.Size = new System.Drawing.Size(121, 20);
            this.comboBox_select_port.TabIndex = 7;
            this.comboBox_select_port.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label_Baud_rate
            // 
            this.label_Baud_rate.AutoSize = true;
            this.label_Baud_rate.Location = new System.Drawing.Point(388, 181);
            this.label_Baud_rate.Name = "label_Baud_rate";
            this.label_Baud_rate.Size = new System.Drawing.Size(59, 12);
            this.label_Baud_rate.TabIndex = 8;
            this.label_Baud_rate.Text = "Baud Rate";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 443);
            this.Controls.Add(this.label_Baud_rate);
            this.Controls.Add(this.comboBox_select_port);
            this.Controls.Add(this.label_selet_port);
            this.Controls.Add(this.comboBox_Baud_rate);
            this.Controls.Add(this.label_tettle);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.button_ok);
            this.Name = "main";
            this.Text = "JJ";
            this.Load += new System.EventHandler(this.主界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Label label_tettle;
        private System.Windows.Forms.ComboBox comboBox_Baud_rate;
        private System.Windows.Forms.Label label_selet_port;
        private System.Windows.Forms.ComboBox comboBox_select_port;
        private System.Windows.Forms.Label label_Baud_rate;
    }
}

