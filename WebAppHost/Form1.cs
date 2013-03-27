﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WebAppHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void cmddelege(string arg);

        private void Form1_Load(object sender, EventArgs e)
        {
            string xmlpath= AppDomain.CurrentDomain.BaseDirectory + "\\" + "config.xml";
            //如果不存在配置文件
            if (!File.Exists(xmlpath))
            {
                try
                {
                    SystemHelper.CreateConfigFile(xmlpath);
                }
                catch (Exception ex)
                {

                    lblstatus.Text = ex.Message;
                    return;
                }
                
            }
             
            XmlHelper xmlHelper = new XmlHelper(xmlpath);
            string command = xmlHelper.SelectNodeText(ConfigPath.RunCommand);
            this.Text = xmlHelper.SelectNodeText(ConfigPath.FormTitle);
            var cmd = new Command();


            ParameterizedThreadStart thread = cmd.RunCmd;
            Thread mythread = new Thread(thread);
            object o = command;
            mythread.Start(o);
            // cmd.RunCmd(command,0);
            webBrowser1.Url = new Uri(xmlHelper.SelectNodeText(ConfigPath.BrowserUrl));
        }
    }
}
