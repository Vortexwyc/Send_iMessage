using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send_iMessage
{
    /// <summary>进度条窗口</summary>
    public partial class ProgressBar : Form
    {
        public ProgressBar(int vMax)
        {
            InitializeComponent();
            this.progressBar1.Maximum = vMax;
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {

        }

        private Send_iMessage thread = null;
        public bool Increase(int nValue, string nInfo)
        {
            if (nValue > 0)
            {
                if (progressBar1.Value + nValue < progressBar1.Maximum)
                {
                    progressBar1.Value += nValue;
                    this.textBox1.Text = nInfo;
                    Application.DoEvents();
                    progressBar1.Update();
                    progressBar1.Refresh();
                    this.textBox1.Update();
                    this.textBox1.Refresh();
                    return true;
                }
                else
                {
                    progressBar1.Value = progressBar1.Maximum;
                    this.textBox1.Text = nInfo;
                    //this.Close();//执行完之后，自动关闭子窗体
                    //thread = new Send_iMessage();
                    //thread.thdSub.Abort();
                    return false;
                }
            }
            return false;
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static implicit operator DataFormats.Format(ProgressBar v)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净。参数0：代表程序正常退出；参数1：代表程序非正常退出。



        }
    }
}
