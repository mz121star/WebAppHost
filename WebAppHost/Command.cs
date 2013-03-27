using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;



namespace WebAppHost
{
    /// <summary> 
    /// Command 的摘要说明。 
    /// </summary> 
    public class Command
    {
        private Process proc = null;
        /// <summary> 
        /// 构造方法 
        /// </summary> 
        public Command()
        {
            proc = new Process();
        }
        /// <summary> 
        /// 执行CMD语句 
        /// </summary> 
        /// <param name="cmd">要执行的CMD命令</param> 
        public void RunCmd(object cmd)
        {
             
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd.ToString());
            //string tempstr = proc.StandardOutput.ReadToEnd();
            //string outstr = "";
            //while (tempstr!="")
            //{
            //    outstr += tempstr;
            //    tempstr = proc.StandardOutput.ReadLine();
            //}
            
           // proc.Close();
           // return tempstr;
        }

        // public string RunCmd(string command, int milliseconds)
        //{            
            
           
        //    string res = string.Empty;

            
        //    proc.StartInfo.FileName = "cmd.exe";          
        //    proc.StartInfo.Arguments = "/c " + command;    
        //    proc.StartInfo.UseShellExecute = true;        
        //    proc.StartInfo.RedirectStandardInput = true;   
        //    proc.StartInfo.RedirectStandardOutput = true;  
        //    proc.StartInfo.RedirectStandardError = true;   
        //   proc.StartInfo.CreateNoWindow = true;          

        //    try
        //    {
        //        if (proc.Start())       //开始进程
        //        {
        //            if (milliseconds == 0)
        //                proc.WaitForExit();     //这里无限等待进程结束
        //            else
        //                proc.WaitForExit(milliseconds);  //这里等待进程结束，等待时间为指定的毫秒     

        //            res = proc.StandardOutput.ReadToEnd();
        //        }
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        if (proc != null)
        //            proc.Close();

                 
        //    }
                        
        //    return res;       
        //}
        /// <summary> 
        /// 打开软件并执行命令 
        /// </summary> 
        /// <param name="programName">软件路径加名称（.exe文件）</param> 
        /// <param name="cmd">要执行的命令</param> 
        public void RunProgram(string programName, string cmd)
        {
            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = programName;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            if (cmd.Length != 0)
            {
                proc.StandardInput.WriteLine(cmd);
            }
            proc.Close();
        }
        /// <summary> 
        /// 打开软件 
        /// </summary> 
        /// <param name="programName">软件路径加名称（.exe文件）</param> 
        public void RunProgram(string programName)
        {
            this.RunProgram(programName, "");
        }





       
    }
}