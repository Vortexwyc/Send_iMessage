using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Send_iMessage
{


    /// <summary>主窗口</summary>
    public partial class Send_iMessage : System.Windows.Forms.Form
    {
        /// <summary>实例化的自定义方法</summary>
        MyMethod Method = new MyMethod();


        public Send_iMessage()
        {
            InitializeComponent();
        }

        private void Send_iMessage_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Send_iMessage_Resize);//窗体调整大小时引发事件

            MyVariable.width = this.Width;//获取窗体的宽度
            MyVariable.height = this.Height;//获取窗体的高度
            SetTag(this);//调用方法
        }
        /// <summary>获取控件的width、height、left、top、字体大小的值</summary>
        private void SetTag(Control cons)
        {
            //遍历窗体中的控件
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    SetTag(con);
            }
        }
        /// <summary>根据窗体大小调整控件大小</summary>
        private void SetControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//获取控件的Tag属性值，并分割后存储字符串数组
                float a = Convert.ToSingle(mytag[0]) * newx;//根据窗体缩放比例确定控件的值，宽度
                con.Width = (int)a;//宽度
                a = Convert.ToSingle(mytag[1]) * newy;//高度
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;//左边距离
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;//上边缘距离
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * newy;//字体大小
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    SetControls(newx, newy, con);
                }
            }
        }
        /// <summary>  对窗体添加Resize()函数</summary>
        void Send_iMessage_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / MyVariable.width; //窗体宽度缩放比例
            float newy = this.Height / MyVariable.height;//窗体高度缩放比例
            SetControls(newx, newy, this);//随窗体改变控件大小
            //this.Text = this.Width.ToString() + " " + this.Height.ToString();//窗体标题栏文本
        }


        private void Button_启动_Click(object sender, EventArgs e)
        {

            if (Method.Check())
            {
                Method.Log("序列号路径:" + MyVariable.path_serial + "\r\n" + "appleID路径:" + MyVariable.path_appleID + "\r\n" + "联系人路径:" + MyVariable.path_contact + "\r\n", true);
                //步骤1:先全部克隆
                for (int i = 0; i < MyVariable.sum; i++)
                {
                    //MessageBox.Show("sum" + MyVariable.sum);
                    //解析文件

                    string[] split_serial = MyVariable.array_serial[i].Split(new char[] { ':' });
                    //处理ROM,加%
                    string s = split_serial[1];
                    s = split_serial[1].Insert(2, "%");
                    s = s.Insert(5, "%");
                    s = s.Insert(8, "%");
                    s = s.Insert(11, "%");
                    s = s.Insert(14, "%");
                    MyVariable.ROM.Add("%" + s);
                    MyVariable.MLB.Add(split_serial[2]);
                    MyVariable.serialNumber.Add(split_serial[3]);
                    MyVariable.appendVmx.Add("efi.nvram.var.ROM = " + MyVariable.ROM[i] + "\r\n" + "efi.nvram.var.ROM.reflectHost = \"FALSE\"" + "\r\n" + "efi.nvram.var.MLB = " + MyVariable.MLB[i] + "\r\n" + "efi.nvram.var.MLB.reflectHost = \"FALSE\"" + "\r\n" + "smbios.reflectHost = \"FALSE\"" + "\r\n" + "serialNumber = " + MyVariable.serialNumber[i] + "\r\n" + "serialNumber.reflectHost = \"FALSE\"" + "\r\n" + "board-id = Mac-CAD6701F7CEA0921" + "\r\n" + "board-id.reflectHost = \"FALSE\"" + "\r\n" + "hw.model = MacBookPro14,2" + "\r\n" + "hw.model.reflectHost = \"FALSE\"");
                    //克隆
                    Method.Clone(MyVariable.appleID[i], "qqy", true);
                    //修改副本VMX
                    Method.UpdataVMX(MyVariable.appleID[i], MyVariable.appendVmx[i]);
                    //更新统计栏
                    Label_cloneNum.Text = (i + 1).ToString() + "/" + MyVariable.sum.ToString();
                }
                //步骤2:倒计时,然后启动
                Timer_counter.Enabled = true;
                Timer_counter.Start();







                //操作完成
                //更新统计栏
                Label_startNum.Text = "0";
            }

        }

        private void Button_退出_Click(object sender, EventArgs e)
        {

            System.Environment.Exit(0);
        }
        /// <summary>删除所有副本</summary>
        private void Button_delVmx_Click(object sender, EventArgs e)
        {
            //先关闭所有虚拟机
            Method.Stop(true);
            try
            {            //删除VM副本
                if (Directory.Exists(MyVariable.path_clone))//判断是否存在
                {
                    System.IO.Directory.Delete(MyVariable.path_clone, true);
                    MessageBox.Show("副本删除成功!");
                    //更新统计栏
                    Label_cloneNum.Text = "0";
                }
                else
                {
                    MessageBox.Show("没有副本!", "副本删除");
                }
            }
            catch (Exception ex)
            { throw (ex); }

        }
        /// <summary>显示序列号,初始化序列号文件的路径和序列号集合</summary>
        private void Button_addSerial_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.InitialDirectory = @"C:\Users\Administrator\Desktop";
                dialog.Title = "请选择序列号文件";
                dialog.Filter = "序列号文件(*.txt*)|*.txt*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //获取序列号文件的路径()
                        MyVariable.path_serial = dialog.FileName;
                        //清空显示框
                        TextBox_displaySerial.Text = "";
                        //清空list
                        MyVariable.array_serial.Clear();
                        //获取序列号并显示出来
                        string[] lines = File.ReadAllLines(MyVariable.path_serial);
                        MyVariable.sum = lines.Length;
                        foreach (string line in lines)
                        {
                            MyVariable.array_serial.Add(line);
                            TextBox_displaySerial.AppendText(line + Environment.NewLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw (ex);
                    }
                }
                else { }
            }
        }
        /// <summary>显示联系人,初始化联系人文件的路径和联系人集合</summary>
        private void Button_addContact_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = false,
                InitialDirectory = @"C:\Users\Administrator\Desktop",
                Title = "请选择联系人文件",
                Filter = "联系人文件(*.txt*)|*.txt*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //获取联系人文件的路径(发送的对象)

                MyVariable.path_contact = dialog.FileName.ToString();

                //获取联系人并显示出来
                string[] lines = File.ReadAllLines(MyVariable.path_contact);
                //清空显示框
                TextBox_displayContact.Text = "";
                //清空list
                MyVariable.array_contact.Clear();
                //是否+86
                if (CheckBox_contact.Checked)
                {
                    foreach (string line in lines)
                    {
                        MyVariable.array_contact.Add("86" + line);
                        TextBox_displayContact.AppendText("86" + line + Environment.NewLine);
                    }
                }
                else
                {
                    foreach (string line in lines)
                    {
                        MyVariable.array_contact.Add(line);
                        TextBox_displayContact.AppendText(line + Environment.NewLine);
                    }
                }

            }



        }
        private void Event_Imessage(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(this.TextBox_imessage, "信息内容");
        }

        //显示序列号
        private void TextBox_displaySerial_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_displaySerial.Text != "")
            {
                Button_addSerial.ForeColor = Color.Green;

            }
            else
            {
                Button_addSerial.ForeColor = Color.Black;
            }
        }
        /// <summary>显示appleID,初始化appleID文件的路径和appleID集合</summary>
        private void Button_addAppleID_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.InitialDirectory = @"C:\Users\Administrator\Desktop";
                dialog.Title = "请选择appleID文件";
                dialog.Filter = "appleID文件(*.txt*)|*.txt*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //获取appleID文件的路径()
                        MyVariable.path_appleID = dialog.FileName;
                        //清空显示框
                        TextBox_displayAppleID.Text = "";
                        //清空list
                        MyVariable.appleID.Clear();
                        MyVariable.applePwd.Clear();
                        //获取appleID并显示出来
                        string[] lines = File.ReadAllLines(MyVariable.path_appleID);
                        foreach (string line in lines)
                        {
                            //苹果账号信息(账号和密码)存入集合
                            string[] split_appleID = line.Split(new char[] { '@' });
                            string[] split_applePwd = line.Split(new char[] { '|' });
                            MyVariable.appleID.Add(split_appleID[0]);
                            MyVariable.applePwd.Add(split_applePwd[1]);
                            //显示账号内容到编辑框
                            TextBox_displayAppleID.AppendText(line + Environment.NewLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw (ex);
                    }
                }
                else { }


            }
        }

        //创建代理。
        private ProgressBar myProcessBar = null;//弹出的子窗体(用于显示进度条)
        private delegate bool IncreaseHandle(int nValue, string vinfo);//代理创建
        private IncreaseHandle myIncrease = null;//声明代理，用于后面的实例化代理
        private int vMax = 100;//用于实例化进度条，可以根据自己的需要，自己改变
        public Thread thdSub = null;
        /// <summary>测试按钮</summary>
        private void Button_test_Click(object sender, EventArgs e)
        {

            //Scripting.FileSystemObject fso = new Scripting.FileSystemObjectClass();
            //if (Directory.Exists(MyVariable.path_clone))
            //{
            //    MessageBox.Show(fso.GetFolder(MyVariable.path_clone).Size.ToString());
            //}
            //thdSub = new Thread(new ThreadStart(ThreadFun));
            //thdSub.Start();
        }

        private void ThreadFun()
        {

            MethodInvoker mi = new MethodInvoker(ShowProcessBar);
            this.BeginInvoke(mi);
            Thread.Sleep(100);
            object objReturn = null;
            for (int i = 0; i < vMax; i++)
            {
                objReturn = this.Invoke(this.myIncrease, new object[] { 2, i.ToString() + "\r\n" });
                Thread.Sleep(1);
            }
        }

        private void ShowProcessBar()
        {
            myProcessBar = new ProgressBar(vMax);
            myIncrease = new IncreaseHandle(myProcessBar.Increase);
            myProcessBar.ShowDialog();
            myProcessBar = null;
        }

        private void TextBox_displayContact_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_displayContact.Text != "")
            {
                Button_addContact.ForeColor = Color.Green;

            }
            else
            {
                Button_addContact.ForeColor = Color.Black;
            }
        }

        private void Label_windowNum_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_sleep_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_sleep.Text != "")
            {
                MyVariable.sleep = int.Parse(TextBox_sleep.Text);
                MyVariable.sleep_s = MyVariable.sleep * 3600;
            }
            else
            {
                MyVariable.sleep = 0;
            }
            if (MyVariable.sleep != 0)
            {
                Label_sleep.Visible = true;
                Label_sleep.Text = "剩余时间: " + MyVariable.sleep.ToString() + "时0分0秒";
            }
        }

        private void TextBox_windowNum_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_windowNum.Text != "")
            {
                MyVariable.windowNum = int.Parse(TextBox_windowNum.Text);
            }
            else
            {
                MyVariable.windowNum = 0;
            }

        }

        private void TextBox_error_TextChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未检测到!", "警告");
        }

        private void Button_exportSuccessContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未检测到!", "警告");
        }

        private void Button_exportSurplusSerial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未检测到!", "警告");
        }

        private void Button_exportSurplusID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未检测到!", "警告");
        }

        private void TextBox_displayAppleID_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_displayAppleID.Text != "")
            {
                Button_addAppleID.ForeColor = Color.Green;

            }
            else
            {
                Button_addAppleID.ForeColor = Color.Black;
            }
        }

        private void TextBox_imessage_TextChanged(object sender, EventArgs e)
        {

            if (TextBox_imessage.Text != "")
            {
                MyVariable.messages = TextBox_imessage.Text;

            }


        }

        private void CheckBox_contact_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_contact.Checked)
            {
                CheckBox_contact.ForeColor = Color.Green;
            }
            else
            {
                CheckBox_contact.ForeColor = Color.Black;
            }
        }

        private void CheckBox_addString_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_addString.Checked)
            {
                CheckBox_addString.ForeColor = Color.Green;
            }
            else
            {
                CheckBox_addString.ForeColor = Color.Black;
            }
        }

        private void Label_cloneNum_Click(object sender, EventArgs e)
        {

        }
        /// <summary>倒计时的显示框</summary>
        private void Label_sleep_Click(object sender, EventArgs e)
        {

        }
        /// <summary>倒计时,然后启动副本计时器</summary>
        private void Timer_counter_Tick(object sender, EventArgs e)
        {
            if (MyVariable.sleep_s < 0)
            {
                Label_sleep.Visible = false;
                Timer_start.Enabled = true;
                Timer_start.Start();
                Timer_counter.Stop();
                Timer_counter.Enabled = false;
            }
            else
            {
                int h = MyVariable.sleep_s / 3600;
                int m = (MyVariable.sleep_s - (h * 3600)) / 60;
                int s = MyVariable.sleep_s - h * 3600 - m * 60;
                Label_sleep.Text = "剩余时间: " + h.ToString() + "时" + m.ToString() + "分" + s.ToString() + "秒";

                MyVariable.sleep_s--;
            }
        }
        /// <summary>启动副本</summary>
        private void Timer_start_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < MyVariable.windowNum; i++)
            {
                Method.Start(MyVariable.appleID[i], true);
                //更新统计栏
                Label_startNum.Text = (i + 1).ToString() + "/" + MyVariable.windowNum.ToString();
            }
            Timer_start.Stop();
            Timer_start.Enabled = false;
        }

    }


    /// <summary>测试</summary>
    public class Test
    {
        public bool status = true;
        /// <summary>控制error框的是否可见</summary>
        public bool Error_IsShow()
        {

            if (status)
            {
                status = false;
            }
            else
            {
                status = true;
            }
            return status;
        }
    }

}
