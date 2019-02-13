using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Send_iMessage
{
    /// <summary>方法</summary>
    internal class MyMethod
    {
        /// <summary>写入日志(内容,是否追加)</summary>
        public void Log(string s, bool append)
        {
            if (append)
            {
                StreamWriter Sw = File.AppendText(@"C: \Users\Administrator\Desktop\log.txt");
                Sw.Write(s);
                Sw.Close();
            }
            else
            {
                File.WriteAllText(@"C: \Users\Administrator\Desktop\log.txt", s);
            }

        }
        /// <summary>创建bat文件并执行命令(命令,是否删除)</summary>
        public void Createbat(string command, bool del)
        {
            try
            {
                //创建文件
                using (FileStream fs = new FileStream(MyVariable.path_bat + "\\" + "qqy.bat", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(command);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                    //隐藏
                    File.SetAttributes(MyVariable.path_bat + "\\" + "qqy.bat", FileAttributes.Hidden);
                }
                //执行bat文件
                Process proc = null;
                try
                {
                    //string targetDir = string.Format(filePath);//这是bat存放的目录
                    //string targetDir1 = AppDomain.CurrentDomain.BaseDirectory; //或者这样写，获取程序目录
                    proc = new Process();
                    //proc.StartInfo.WorkingDirectory = targetDir1;
                    proc.StartInfo.FileName = MyVariable.path_bat + "\\" + "qqy.bat";//bat文件名称
                    proc.StartInfo.Arguments = string.Format("10");//this is argument
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;//这里设置DOS窗口不显示，经实践可行
                    proc.Start();
                    proc.WaitForExit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
                }
            }
            catch
            {
                //"保存文本文件出错！"
                MessageBox.Show("生成bat文件出错!!");
            }
            if (del)
            {

                //删除bat文件
                System.IO.File.Delete(MyVariable.path_bat + "\\" + "qqy.bat");

            }
            else
            {
                //取消隐藏
                File.SetAttributes(MyVariable.path_bat + "\\" + "qqy.bat", FileAttributes.Normal);
            }
        }

        /// <summary>克隆(副本vmx的名字,快照名字,是否删除bat)</summary>
        public void Clone(string cloneName, string snapshotName, bool del)
        {
            //初始化bat命令
            string command1 = @"cd C:\VMware\VMware Workstation";
            string command2 = "vmrun -T ws clone \"C:\\VMwareOS\\qqy\\qqy.vmx\" " + "\"" + MyVariable.path_clone + "\\" + cloneName + "\\" + cloneName + ".vmx\" full -snapshot=" + snapshotName + " -cloneName=" + cloneName;
            string command = command1 + "\r\n" + command2;
            Log("克隆:" + "\r\n" + command, false);
            Createbat(command, del);

        }

        /// <summary>启动副本(副本名,是否删除bat)</summary>
        public void Start(string name_VMX, bool del)
        {
            string command1 = @"cd C:\VMware\VMware Workstation";
            string command2 = "vmrun -T ws start " + MyVariable.path_clone + "\\" + name_VMX + "\\" + name_VMX + ".vmx";
            string command = command1 + "\r\n" + command2;
            Createbat(command, del);

        }

        /// <summary>关闭所有虚拟机(是否删除bat)</summary>
        public void Stop(bool del)
        {
            string command1 = @"cd C:\VMware\VMware Workstation";
            string command2 = "for /f \"skip=1\" %%i in ('vmrun list') do (vmrun stop %%i hard)";
            string command = command1 + "\r\n" + command2;
            Createbat(command, del);

        }

        /// <summary>修改副本vmx(vmx路径只填文件名,追加内容)</summary>
        public void UpdataVMX(string name_VMX, string content)
        {
            //追加写入5码,11条数据
            StreamWriter Sw = File.AppendText(MyVariable.path_clone + "\\" + name_VMX + "\\" + name_VMX + ".vmx");
            Sw.Write(content);
            Sw.Close();
            //还要写入共享文件加,添加共享文件
        }
        /// <summary>检查必要条件是否满足</summary>
        public bool Check()
        {
            //检测前置变量
            if (MyVariable.windowNum <= 0)
            {
                MessageBox.Show("请先输入要创建的窗口数量!", "警告");
                return false;

            }
            else if (MyVariable.sleep < 0)
            {
                MessageBox.Show("等待时间错误!", "警告");
                return false;
            }
            else if (MyVariable.messages == "")
            {
                MessageBox.Show("请先输入要发送的信息!", "警告");
                return false;
            }
            else if (MyVariable.sum == 0)
            {
                MessageBox.Show("序列号已用完", "警告");
                return false;
            }
            else if (MyVariable.path_serial == "" || MyVariable.path_appleID == "" || MyVariable.path_contact == "")
            {
                MessageBox.Show("文件路径错误!!请重新添加文件", "警告");
                return false;
            }
            else
            {
                return true;
            }
        }

    }

}
