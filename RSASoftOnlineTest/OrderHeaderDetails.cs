using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RSASoftOnline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSASoftOnlineTest
{
    [TestClass]
    public class OrderHeaderDetails
    {
        [TestMethod]
        public void Test_GetNumberLines()
        {
            List<RSASoftOnline.OrderLineDetails> LineDetails = new List<RSASoftOnline.OrderLineDetails>();
            RSASoftOnline.OrderHeaderDetails hd = new RSASoftOnline.OrderHeaderDetails
            {
                LineDetails = LineDetails
            };
            Assert.AreEqual(hd.GetNumberLines(), 1);
        }
    }
}
