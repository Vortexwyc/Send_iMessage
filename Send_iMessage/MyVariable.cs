using System.Collections.Generic;

namespace Send_iMessage
{
    /// <summary>初始化变量</summary>
    internal static class MyVariable
    {
        /// <summary>生成bat文件的路径(C:\Users\Administrator\Desktop\VStest.bat)</summary>
        public static string path_bat = @"C:\Users\Administrator\Desktop\";
        /// <summary>所有虚拟机副本的存放目录(C:\VMwareOS\clone)</summary>
        public static string path_clone = "C:\\VMwareOS\\clone";
        /// <summary>共享文件夹路径(C:\VMwareOS\share)</summary>
        public static string path_share = "C:\\VMwareOS\\share";
        /// <summary>联系人文件的路径</summary>
        public static string path_contact = "";
        /// <summary>序列号文件的路径</summary>
        public static string path_serial = "";
        /// <summary>苹果账号文件的路径</summary>
        public static string path_appleID = "";


        /// <summary>总执行次数</summary>
        public static int sum = 0;
        /// <summary>创建窗口数量</summary>
        public static int windowNum = 0;
        /// <summary>发送的信息</summary>
        public static string messages = "";
        /// <summary>克隆数</summary>
        public static int cloneNum = 0;
        /// <summary>等待时间(h)</summary>
        public static int sleep = 0;
        /// <summary>等待时间(s)</summary>
        public static int sleep_s = 0;
        /// <summary>主窗体的宽度</summary>
        public static float width = 0;
        /// <summary>主窗体的长度</summary>
        public static float height = 0;


        /// <summary>ROM的集合</summary>
        public static List<string> ROM = new List<string>();
        /// <summary>MLB的集合</summary>
        public static List<string> MLB = new List<string>();
        /// <summary>serialNumber的集合</summary>
        public static List<string> serialNumber = new List<string>();
        /// <summary>修改VMX内容的集合,一个元素为一个副本的修改</summary>
        public static List<string> appendVmx = new List<string>();
        /// <summary>以appleId账号为虚拟机副本的名字的集合</summary>
        public static List<string> appleID = new List<string>();
        /// <summary>用来存放所有苹果密码的集合</summary>
        public static List<string> applePwd = new List<string>();

        /// <summary>用来存放所有联系人的集合</summary>
        public static List<string> array_contact = new List<string>();
        /// <summary>用来存放所有序列号的集合</summary>
        public static List<string> array_serial = new List<string>();



    }

}