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
using System.Threading;

namespace JINGJING
{
    public partial class main : Form
    {
        #region 变量初始化
        /// <summary>
        /// 后台线程
        /// </summary>
        Thread PThread;

        /// <summary>
        /// 波形串口
        /// </summary>
        SerialPort WavePort = new SerialPort();
        #endregion

        public main()
        {
            InitializeComponent();
        }

        private void 主界面_Load(object sender, EventArgs e)
        {
            InitThread();//初始化线程
            comboBox_Baud_rate.DataSource = new[] { "125000", "360000", "251000" };
            string[] PortStr = SerialPort.GetPortNames();
            comboBox_select_port.DataSource =  PortStr; 
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke((Action)(()=> {
                //判断串口是否打开
                if (WavePort.IsOpen)
                {
                    SaveData();
                    PlotWave();
                }
            }));
        }

        #region 线程初始化
        private void InitThread()
        {
            try
            {
                PThread = new Thread(
                    ()=>
                    {
                        while (true)
                        {
                            this.Invoke(
                                (MethodInvoker)delegate ()
                                {                                    
                                      this.BeginInvoke((Action)(()=>
                                      {
                                          backgroundWorker1.RunWorkerAsync();
                                      }));                                    
                                }
                                );
                            Thread.Sleep(1000);//sleep1s
                        }
                    }
                    );
                PThread.Priority = ThreadPriority.Highest;//优先级设为最高
                PThread.IsBackground = true;//属性设置为后台线程
                PThread.Start();//线程启动
            }
            catch(Exception ex)
            {
                return;
            }
        }
        #endregion

        #region 保存波形数据
        /// <summary>
        /// 保存波形数据
        /// </summary>
        private void SaveData()
        {
            try
            {
                int DataLength = WavePort.BytesToRead;//缓冲区中数据字节数
                byte[] DataReceived = new byte[DataLength];//存放缓冲区数据
                if (WavePort.Read(DataReceived, 0, DataLength) == 0) return;

            }
            catch(Exception ex)
            {
                return;
            }
        }
        #endregion

        #region 画波形图
        /// <summary>
        /// 画波形图
        /// </summary>
        private void PlotWave()
        {
            try
            {

            }
            catch(Exception ex)
            {
                return;
            }
        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            WavePort.PortName = comboBox_select_port.Text;
            WavePort.BaudRate = int.Parse(comboBox_Baud_rate.Text);
        }
    }
}
