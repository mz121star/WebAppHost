using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
namespace WebAppHost
{
   public class XmlHelper
    {
       private  XmlDocument xml = null;
       public XmlHelper(string path){
           
           if (xml == null)
           {
               xml=new XmlDocument();
               xml.Load(  path);
           }
               
           
            
       }
      

       /// <summary>
       /// 选择节点的内容
       /// </summary>
       /// <param name="nodepath"></param>
       /// <returns></returns>
       public  string SelectNodeText(string nodepath)
       {
          // XmlNode root = xml.SelectSingleNode("/configs/cmdconfig");
           XmlNode node = xml.SelectSingleNode(nodepath);
           if (node != null) return node.InnerText;
           return null;
       }
    }
}
