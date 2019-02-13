namespace Send_iMessage
{
    partial class Send_iMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send_iMessage));
            this.Button_addContact = new System.Windows.Forms.Button();
            this.TextBox_displayContact = new System.Windows.Forms.TextBox();
            this.TextBox_displaySerial = new System.Windows.Forms.TextBox();
            this.Button_addSerial = new System.Windows.Forms.Button();
            this.Button_退出 = new System.Windows.Forms.Button();
            this.Button_启动 = new System.Windows.Forms.Button();
            this.Button_delVmx = new System.Windows.Forms.Button();
            this.TextBox_imessage = new System.Windows.Forms.TextBox();
            this.TextBox_sleep = new System.Windows.Forms.TextBox();
            this.Label_sendImessage = new System.Windows.Forms.Label();
            this.Lab = new System.Windows.Forms.Label();
            this.Label_windowNum = new System.Windows.Forms.Label();
            this.TextBox_windowNum = new System.Windows.Forms.TextBox();
            this.TextBox_sendFaildNum = new System.Windows.Forms.TextBox();
            this.Label_sendFaildNum = new System.Windows.Forms.Label();
            this.Button_test = new System.Windows.Forms.Button();
            this.Button_addAppleID = new System.Windows.Forms.Button();
            this.TextBox_displayAppleID = new System.Windows.Forms.TextBox();
            this.TextBox_error = new System.Windows.Forms.TextBox();
            this.CheckBox_contact = new System.Windows.Forms.CheckBox();
            this.Button_exportSurplusSerial = new System.Windows.Forms.Button();
            this.Button_exportSuccessContact = new System.Windows.Forms.Button();
            this.Button_exportSurplusID = new System.Windows.Forms.Button();
            this.Button_exportFaildContact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBox_addString = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_cloneNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Labe = new System.Windows.Forms.Label();
            this.Label_startNum = new System.Windows.Forms.Label();
            this.Label_sleep = new System.Windows.Forms.Label();
            this.Timer_counter = new System.Windows.Forms.Timer(this.components);
            this.Timer_start = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Button_addContact
            // 
            this.Button_addContact.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Button_addContact.ForeColor = System.Drawing.Color.Black;
            this.Button_addContact.Location = new System.Drawing.Point(96, 94);
            this.Button_addContact.Name = "Button_addContact";
            this.Button_addContact.Size = new System.Drawing.Size(167, 31);
            this.Button_addContact.TabIndex = 0;
            this.Button_addContact.Text = "添加联系人文件";
            this.Button_addContact.UseVisualStyleBackColor = true;
            this.Button_addContact.Click += new System.EventHandler(this.Button_addContact_Click);
            // 
            // TextBox_displayContact
            // 
            this.TextBox_displayContact.Location = new System.Drawing.Point(31, 209);
            this.TextBox_displayContact.MaximumSize = new System.Drawing.Size(250, 500);
            this.TextBox_displayContact.MinimumSize = new System.Drawing.Size(250, 470);
            this.TextBox_displayContact.Multiline = true;
            this.TextBox_displayContact.Name = "TextBox_displayContact";
            this.TextBox_displayContact.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_displayContact.Size = new System.Drawing.Size(250, 470);
            this.TextBox_displayContact.TabIndex = 2;
            this.TextBox_displayContact.WordWrap = false;
            this.TextBox_displayContact.TextChanged += new System.EventHandler(this.TextBox_displayContact_TextChanged);
            // 
            // TextBox_displaySerial
            // 
            this.TextBox_displaySerial.Location = new System.Drawing.Point(296, 170);
            this.TextBox_displaySerial.MaximumSize = new System.Drawing.Size(250, 500);
            this.TextBox_displaySerial.MinimumSize = new System.Drawing.Size(250, 500);
            this.TextBox_displaySerial.Multiline = true;
            this.TextBox_displaySerial.Name = "TextBox_displaySerial";
            this.TextBox_displaySerial.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_displaySerial.Size = new System.Drawing.Size(250, 500);
            this.TextBox_displaySerial.TabIndex = 3;
            this.TextBox_displaySerial.WordWrap = false;
            this.TextBox_displaySerial.TextChanged += new System.EventHandler(this.TextBox_displaySerial_TextChanged);
            // 
            // Button_addSerial
            // 
            this.Button_addSerial.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Button_addSerial.Location = new System.Drawing.Point(296, 89);
            this.Button_addSerial.Name = "Button_addSerial";
            this.Button_addSerial.Size = new System.Drawing.Size(222, 33);
            this.Button_addSerial.TabIndex = 4;
            this.Button_addSerial.Text = "添加序列号文件";
            this.Button_addSerial.UseVisualStyleBackColor = true;
            this.Button_addSerial.Click += new System.EventHandler(this.Button_addSerial_Click);
            // 
            // Button_退出
            // 
            this.Button_退出.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_退出.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_退出.Location = new System.Drawing.Point(909, 507);
            this.Button_退出.Name = "Button_退出";
            this.Button_退出.Size = new System.Drawing.Size(179, 74);
            this.Button_退出.TabIndex = 6;
            this.Button_退出.Text = "退出";
            this.Button_退出.UseVisualStyleBackColor = false;
            this.Button_退出.Click += new System.EventHandler(this.Button_退出_Click);
            // 
            // Button_启动
            // 
            this.Button_启动.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_启动.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_启动.Location = new System.Drawing.Point(903, 351);
            this.Button_启动.Name = "Button_启动";
            this.Button_启动.Size = new System.Drawing.Size(185, 74);
            this.Button_启动.TabIndex = 7;
            this.Button_启动.Text = "启动";
            this.Button_启动.UseVisualStyleBackColor = false;
            this.Button_启动.Click += new System.EventHandler(this.Button_启动_Click);
            // 
            // Button_delVmx
            // 
            this.Button_delVmx.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Button_delVmx.Location = new System.Drawing.Point(886, 641);
            this.Button_delVmx.Name = "Button_delVmx";
            this.Button_delVmx.Size = new System.Drawing.Size(222, 33);
            this.Button_delVmx.TabIndex = 9;
            this.Button_delVmx.Text = "删除虚拟机副本";
            this.Button_delVmx.UseVisualStyleBackColor = true;
            this.Button_delVmx.Click += new System.EventHandler(this.Button_delVmx_Click);
            // 
            // TextBox_imessage
            // 
            this.TextBox_imessage.Font = new System.Drawing.Font("宋体", 15.75F);
            this.TextBox_imessage.Location = new System.Drawing.Point(958, 61);
            this.TextBox_imessage.MaximumSize = new System.Drawing.Size(250, 100);
            this.TextBox_imessage.MinimumSize = new System.Drawing.Size(250, 100);
            this.TextBox_imessage.Multiline = true;
            this.TextBox_imessage.Name = "TextBox_imessage";
            this.TextBox_imessage.Size = new System.Drawing.Size(250, 100);
            this.TextBox_imessage.TabIndex = 11;
            this.TextBox_imessage.TextChanged += new System.EventHandler(this.TextBox_imessage_TextChanged);
            this.TextBox_imessage.MouseEnter += new System.EventHandler(this.Event_Imessage);
            // 
            // TextBox_sleep
            // 
            this.TextBox_sleep.Font = new System.Drawing.Font("宋体", 15.75F);
            this.TextBox_sleep.Location = new System.Drawing.Point(171, 47);
            this.TextBox_sleep.Name = "TextBox_sleep";
            this.TextBox_sleep.Size = new System.Drawing.Size(39, 31);
            this.TextBox_sleep.TabIndex = 18;
            this.TextBox_sleep.Text = "0";
            this.TextBox_sleep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_sleep.TextChanged += new System.EventHandler(this.TextBox_sleep_TextChanged);
            // 
            // Label_sendImessage
            // 
            this.Label_sendImessage.AutoSize = true;
            this.Label_sendImessage.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Label_sendImessage.Location = new System.Drawing.Point(826, 64);
            this.Label_sendImessage.Name = "Label_sendImessage";
            this.Label_sendImessage.Size = new System.Drawing.Size(126, 21);
            this.Label_sendImessage.TabIndex = 19;
            this.Label_sendImessage.Text = "发信息内容:";
            // 
            // Lab
            // 
            this.Lab.AutoSize = true;
            this.Lab.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Lab.Location = new System.Drawing.Point(27, 50);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(138, 21);
            this.Lab.TabIndex = 20;
            this.Lab.Text = "等待时间(h):";
            // 
            // Label_windowNum
            // 
            this.Label_windowNum.AutoSize = true;
            this.Label_windowNum.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Label_windowNum.Location = new System.Drawing.Point(216, 50);
            this.Label_windowNum.Name = "Label_windowNum";
            this.Label_windowNum.Size = new System.Drawing.Size(147, 21);
            this.Label_windowNum.TabIndex = 21;
            this.Label_windowNum.Text = "创建窗口数量:";
            this.Label_windowNum.Click += new System.EventHandler(this.Label_windowNum_Click);
            // 
            // TextBox_windowNum
            // 
            this.TextBox_windowNum.Font = new System.Drawing.Font("宋体", 15.75F);
            this.TextBox_windowNum.Location = new System.Drawing.Point(369, 47);
            this.TextBox_windowNum.Name = "TextBox_windowNum";
            this.TextBox_windowNum.Size = new System.Drawing.Size(39, 31);
            this.TextBox_windowNum.TabIndex = 22;
            this.TextBox_windowNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_windowNum.TextChanged += new System.EventHandler(this.TextBox_windowNum_TextChanged);
            // 
            // TextBox_sendFaildNum
            // 
            this.TextBox_sendFaildNum.Font = new System.Drawing.Font("宋体", 15.75F);
            this.TextBox_sendFaildNum.Location = new System.Drawing.Point(567, 47);
            this.TextBox_sendFaildNum.Name = "TextBox_sendFaildNum";
            this.TextBox_sendFaildNum.Size = new System.Drawing.Size(39, 31);
            this.TextBox_sendFaildNum.TabIndex = 24;
            this.TextBox_sendFaildNum.Text = "10";
            this.TextBox_sendFaildNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_sendFaildNum
            // 
            this.Label_sendFaildNum.AutoSize = true;
            this.Label_sendFaildNum.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Label_sendFaildNum.Location = new System.Drawing.Point(414, 50);
            this.Label_sendFaildNum.Name = "Label_sendFaildNum";
            this.Label_sendFaildNum.Size = new System.Drawing.Size(147, 21);
            this.Label_sendFaildNum.TabIndex = 23;
            this.Label_sendFaildNum.Text = "发送失败次数:";
            // 
            // Button_test
            // 
            this.Button_test.Font = new System.Drawing.Font("宋体", 9F);
            this.Button_test.Location = new System.Drawing.Point(800, 832);
            this.Button_test.Name = "Button_test";
            this.Button_test.Size = new System.Drawing.Size(75, 43);
            this.Button_test.TabIndex = 25;
            this.Button_test.Text = "开发者按钮";
            this.Button_test.UseVisualStyleBackColor = true;
            this.Button_test.Visible = false;
            this.Button_test.Click += new System.EventHandler(this.Button_test_Click);
            // 
            // Button_addAppleID
            // 
            this.Button_addAppleID.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Button_addAppleID.Location = new System.Drawing.Point(562, 89);
            this.Button_addAppleID.Name = "Button_addAppleID";
            this.Button_addAppleID.Size = new System.Drawing.Size(222, 33);
            this.Button_addAppleID.TabIndex = 26;
            this.Button_addAppleID.Text = "添加appleID文件";
            this.Button_addAppleID.UseVisualStyleBackColor = true;
            this.Button_addAppleID.Click += new System.EventHandler(this.Button_addAppleID_Click);
            // 
            // TextBox_displayAppleID
            // 
            this.TextBox_displayAppleID.Location = new System.Drawing.Point(562, 170);
            this.TextBox_displayAppleID.MaximumSize = new System.Drawing.Size(250, 500);
            this.TextBox_displayAppleID.MinimumSize = new System.Drawing.Size(250, 500);
            this.TextBox_displayAppleID.Multiline = true;
            this.TextBox_displayAppleID.Name = "TextBox_displayAppleID";
            this.TextBox_displayAppleID.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_displayAppleID.Size = new System.Drawing.Size(250, 500);
            this.TextBox_displayAppleID.TabIndex = 27;
            this.TextBox_displayAppleID.WordWrap = false;
            this.TextBox_displayAppleID.TextChanged += new System.EventHandler(this.TextBox_displayAppleID_TextChanged);
            // 
            // TextBox_error
            // 
            this.TextBox_error.Location = new System.Drawing.Point(675, 701);
            this.TextBox_error.MaximumSize = new System.Drawing.Size(200, 100);
            this.TextBox_error.MinimumSize = new System.Drawing.Size(200, 100);
            this.TextBox_error.Multiline = true;
            this.TextBox_error.Name = "TextBox_error";
            this.TextBox_error.ReadOnly = true;
            this.TextBox_error.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_error.Size = new System.Drawing.Size(200, 100);
            this.TextBox_error.TabIndex = 28;
            this.TextBox_error.Text = "13";
            this.TextBox_error.Visible = false;
            this.TextBox_error.WordWrap = false;
            this.TextBox_error.TextChanged += new System.EventHandler(this.TextBox_error_TextChanged);
            // 
            // CheckBox_contact
            // 
            this.CheckBox_contact.AutoSize = true;
            this.CheckBox_contact.Font = new System.Drawing.Font("宋体", 15.75F);
            this.CheckBox_contact.Location = new System.Drawing.Point(31, 97);
            this.CheckBox_contact.Name = "CheckBox_contact";
            this.CheckBox_contact.Size = new System.Drawing.Size(62, 25);
            this.CheckBox_contact.TabIndex = 29;
            this.CheckBox_contact.Text = "+86";
            this.CheckBox_contact.UseVisualStyleBackColor = true;
            this.CheckBox_contact.CheckedChanged += new System.EventHandler(this.CheckBox_contact_CheckedChanged);
            // 
            // Button_exportSurplusSerial
            // 
            this.Button_exportSurplusSerial.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Button_exportSurplusSerial.Location = new System.Drawing.Point(296, 128);
            this.Button_exportSurplusSerial.Name = "Button_exportSurplusSerial";
            this.Button_exportSurplusSerial.Size = new System.Drawing.Size(230, 33);
            this.Button_exportSurplusSerial.TabIndex = 30;
            this.Button_exportSurplusSerial.Text = "导出未使用的序列号";
            this.Button_exportSurplusSerial.UseVisualStyleBackColor = true;
            this.Button_exportSurplusSerial.Click += new System.EventHandler(this.Button_exportSurplusSerial_Click);
            // 
            // Button_exportSuccessContact
            // 
            this.Button_exportSuccessContact.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Button_exportSuccessContact.Location = new System.Drawing.Point(31, 131);
            this.Button_exportSuccessContact.Name = "Button_exportSuccessContact";
            this.Button_exportSuccessContact.Size = new System.Drawing.Size(232, 33);
            this.Button_exportSuccessContact.TabIndex = 31;
            this.Button_exportSuccessContact.Text = "导出发送成功的联系人";
            this.Button_exportSuccessContact.UseVisualStyleBackColor = true;
            this.Button_exportSuccessContact.Click += new System.EventHandler(this.Button_exportSuccessContact_Click);
            // 
            // Button_exportSurplusID
            // 
            this.Button_exportSurplusID.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Button_exportSurplusID.Location = new System.Drawing.Point(562, 128);
            this.Button_exportSurplusID.Name = "Button_exportSurplusID";
            this.Button_exportSurplusID.Size = new System.Drawing.Size(241, 33);
            this.Button_exportSurplusID.TabIndex = 32;
            this.Button_exportSurplusID.Text = "导出未使用的appleID";
            this.Button_exportSurplusID.UseVisualStyleBackColor = true;
            this.Button_exportSurplusID.Click += new System.EventHandler(this.Button_exportSurplusID_Click);
            // 
            // Button_exportFaildContact
            // 
            this.Button_exportFaildContact.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Button_exportFaildContact.Location = new System.Drawing.Point(31, 170);
            this.Button_exportFaildContact.Name = "Button_exportFaildContact";
            this.Button_exportFaildContact.Size = new System.Drawing.Size(232, 33);
            this.Button_exportFaildContact.TabIndex = 33;
            this.Button_exportFaildContact.Text = "导出发送失败的联系人";
            this.Button_exportFaildContact.UseVisualStyleBackColor = true;
            this.Button_exportFaildContact.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F);
            this.label1.Location = new System.Drawing.Point(828, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "验证码:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 15.75F);
            this.textBox1.Location = new System.Drawing.Point(958, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 31);
            this.textBox1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(1100, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "联系方式:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(1100, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "+QQ:";
            // 
            // CheckBox_addString
            // 
            this.CheckBox_addString.AutoSize = true;
            this.CheckBox_addString.Font = new System.Drawing.Font("宋体", 15.75F);
            this.CheckBox_addString.Location = new System.Drawing.Point(830, 105);
            this.CheckBox_addString.Name = "CheckBox_addString";
            this.CheckBox_addString.Size = new System.Drawing.Size(82, 25);
            this.CheckBox_addString.TabIndex = 38;
            this.CheckBox_addString.Text = "+变量";
            this.CheckBox_addString.UseVisualStyleBackColor = true;
            this.CheckBox_addString.CheckedChanged += new System.EventHandler(this.CheckBox_addString_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F);
            this.label4.Location = new System.Drawing.Point(38, 742);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "克隆数:";
            // 
            // Label_cloneNum
            // 
            this.Label_cloneNum.AutoSize = true;
            this.Label_cloneNum.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Label_cloneNum.Location = new System.Drawing.Point(128, 742);
            this.Label_cloneNum.Name = "Label_cloneNum";
            this.Label_cloneNum.Size = new System.Drawing.Size(21, 21);
            this.Label_cloneNum.TabIndex = 40;
            this.Label_cloneNum.Text = "0";
            this.Label_cloneNum.Click += new System.EventHandler(this.Label_cloneNum_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F);
            this.label6.Location = new System.Drawing.Point(38, 707);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "统计:";
            // 
            // Labe
            // 
            this.Labe.AutoSize = true;
            this.Labe.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Labe.Location = new System.Drawing.Point(38, 780);
            this.Labe.Name = "Labe";
            this.Labe.Size = new System.Drawing.Size(105, 21);
            this.Labe.TabIndex = 42;
            this.Labe.Text = "正在启动:";
            // 
            // Label_startNum
            // 
            this.Label_startNum.AutoSize = true;
            this.Label_startNum.Font = new System.Drawing.Font("宋体", 15.75F);
            this.Label_startNum.Location = new System.Drawing.Point(149, 780);
            this.Label_startNum.Name = "Label_startNum";
            this.Label_startNum.Size = new System.Drawing.Size(21, 21);
            this.Label_startNum.TabIndex = 43;
            this.Label_startNum.Text = "0";
            // 
            // Label_sleep
            // 
            this.Label_sleep.AutoSize = true;
            this.Label_sleep.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Label_sleep.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_sleep.ForeColor = System.Drawing.Color.Red;
            this.Label_sleep.Location = new System.Drawing.Point(228, 742);
            this.Label_sleep.Name = "Label_sleep";
            this.Label_sleep.Size = new System.Drawing.Size(350, 35);
            this.Label_sleep.TabIndex = 44;
            this.Label_sleep.Text = "剩余时间: 0时0分0秒";
            this.Label_sleep.Visible = false;
            this.Label_sleep.Click += new System.EventHandler(this.Label_sleep_Click);
            // 
            // Timer_counter
            // 
            this.Timer_counter.Interval = 1000;
            this.Timer_counter.Tick += new System.EventHandler(this.Timer_counter_Tick);
            // 
            // Timer_start
            // 
            this.Timer_start.Interval = 1000;
            this.Timer_start.Tick += new System.EventHandler(this.Timer_start_Tick);
            // 
            // Send_iMessage
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.Label_sleep);
            this.Controls.Add(this.Label_startNum);
            this.Controls.Add(this.Labe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label_cloneNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckBox_addString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_exportFaildContact);
            this.Controls.Add(this.Button_exportSurplusID);
            this.Controls.Add(this.Button_exportSuccessContact);
            this.Controls.Add(this.Button_exportSurplusSerial);
            this.Controls.Add(this.CheckBox_contact);
            this.Controls.Add(this.TextBox_error);
            this.Controls.Add(this.TextBox_displayAppleID);
            this.Controls.Add(this.Button_addAppleID);
            this.Controls.Add(this.Button_test);
            this.Controls.Add(this.TextBox_sendFaildNum);
            this.Controls.Add(this.Label_sendFaildNum);
            this.Controls.Add(this.TextBox_windowNum);
            this.Controls.Add(this.Label_windowNum);
            this.Controls.Add(this.Lab);
            this.Controls.Add(this.Label_sendImessage);
            this.Controls.Add(this.TextBox_sleep);
            this.Controls.Add(this.TextBox_imessage);
            this.Controls.Add(this.Button_delVmx);
            this.Controls.Add(this.Button_启动);
            this.Controls.Add(this.Button_退出);
            this.Controls.Add(this.Button_addSerial);
            this.Controls.Add(this.TextBox_displaySerial);
            this.Controls.Add(this.TextBox_displayContact);
            this.Controls.Add(this.Button_addContact);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Send_iMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "千千亿黑科技";
            this.Load += new System.EventHandler(this.Send_iMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button Button_addContact;
        private System.Windows.Forms.TextBox TextBox_displayContact;
        private System.Windows.Forms.TextBox TextBox_displaySerial;
        private System.Windows.Forms.Button Button_addSerial;
        private System.Windows.Forms.Button Button_退出;
        private System.Windows.Forms.Button Button_启动;
        private System.Windows.Forms.Button Button_delVmx;

        private System.Windows.Forms.TextBox TextBox_imessage;
        private System.Windows.Forms.TextBox TextBox_sleep;
        private System.Windows.Forms.Label Label_sendImessage;
        private System.Windows.Forms.Label Lab;
        private System.Windows.Forms.Label Label_windowNum;
        private System.Windows.Forms.TextBox TextBox_windowNum;
        private System.Windows.Forms.TextBox TextBox_sendFaildNum;
        private System.Windows.Forms.Label Label_sendFaildNum;
        private System.Windows.Forms.Button Button_test;
        private System.Windows.Forms.Button Button_addAppleID;
        private System.Windows.Forms.TextBox TextBox_displayAppleID;
        private System.Windows.Forms.TextBox TextBox_error;
        private System.Windows.Forms.CheckBox CheckBox_contact;
        private System.Windows.Forms.Button Button_exportSurplusSerial;
        private System.Windows.Forms.Button Button_exportSuccessContact;
        private System.Windows.Forms.Button Button_exportSurplusID;
        private System.Windows.Forms.Button Button_exportFaildContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBox_addString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_cloneNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Labe;
        private System.Windows.Forms.Label Label_startNum;
        private System.Windows.Forms.Label Label_sleep;
        private System.Windows.Forms.Timer Timer_counter;
        private System.Windows.Forms.Timer Timer_start;
    }
}

