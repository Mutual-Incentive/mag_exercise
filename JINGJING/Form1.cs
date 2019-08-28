using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace JINGJING
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void 主界面_Load(object sender, EventArgs e)
        {
            comboBox_Baud_rate.DataSource = new[] { "125000", "360000", "251000" };
            string[] PortStr = SerialPort.GetPortNames();
            comboBox_select_port.DataSource =  PortStr; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string Password = "123123";
            if 
                (textbox_password.Text == Password)
            { MessageBox.Show("WELCOME"); }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }      
        private void textbox_password_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
