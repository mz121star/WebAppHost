using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void TestLoadXml()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            WebAppHost.XmlHelper xmlhelper = new WebAppHost.XmlHelper(dir + "\\config.xml");
            Assert.IsNotNull(xmlhelper);
        }
        [TestMethod]
        public void TestSelectNode()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            WebAppHost.XmlHelper xmlhelper = new WebAppHost.XmlHelper(dir + "\\config.xml");
            string text=xmlhelper.SelectNodeText("/configs/cmdconfig");
            Assert.AreEqual("node app.js",text);
        }

    }
}
