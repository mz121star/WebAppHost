using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebAppHost
{
   public class SystemHelper
    {
       public static bool CreateConfigFile(string path)
       {
           try
           {
               FileStream fs = new FileStream(path, FileMode.Create);
               StreamWriter sw = new StreamWriter(fs);
               string config = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
                               "<configs>" +
                               " <!--应用程序配置节点-->" +
                               "<appconfig>" +
                               "<title>football</title>"+
                               "</appconfig>" +
                               "<!--命令配置（程序启动要执行的命令）-->" +
                               "<cmdconfig>" +
                               "<runcommand>node app.js</runcommand>" +
                               "<browserurl>http://localhost:3000</browserurl>"+
                               "</cmdconfig>" +
                               "</configs>";

               sw.Write(config);
               sw.Flush();
               sw.Close();
               fs.Close();
               return true;
           }
           catch (Exception ex)
           {
               throw  new Exception("config.xml create error:"+ex.Message);
               
           }
       }
    }
}
