using LOLHelper.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOLHelper.Debug
{
    public partial class Debug : Form
    {

        private Form followForm;
        private readonly System.Timers.Timer timer = new System.Timers.Timer();
        public Debug(Form followForm)
        {
            InitializeComponent();
            this.followForm = followForm;
        }
        /// <summary>
        /// 写入一行日志
        /// </summary>
        /// <param name="str">日志内容</param>
        public void Log(string str)
        {
            string now = DateTime.Now.ToString();
            if (txtBox_log.InvokeRequired)
            {
                Action<string> actionDelegate = (x) =>
                {
                    txtBox_log.AppendText(now + ": " + x + "\r\n");
                };
                this.txtBox_log.Invoke(actionDelegate, str);
            }
            else
            {
                txtBox_log.Text += now + ": " + str + "\r\n";
            }
        }

        /// <summary>
        /// 修改窗口位置
        /// </summary>
        private void UpdateLocation()
        {
            if (this.InvokeRequired)
            {
                Action<Form> actionDelegate = (followForm) =>
                {
                    Left = followForm.Left + followForm.Width;
                    Top = followForm.Top;
                };
                if (!this.IsDisposed)
                {
                    this.Invoke(actionDelegate, followForm);
                }

            }
        }

        private void Debug_Load(object sender, EventArgs e)
        {

            timer.Interval = 100;
            timer.Elapsed += (s, e1) =>
            {
                UpdateLocation();
            };
            timer.Start();
        }

        private void Debug_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            timer.Close();
        }
    }
}
