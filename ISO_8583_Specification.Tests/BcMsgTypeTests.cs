using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISO_8583_Specification.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ISO_8583_Specification.Tests.TestMessages;

    [TestClass]
    public class BcMsgTypeTests
    {
        [TestMethod]
        public void TestBcdPackUnpack()
        {
            var msg = new BCDIsoMsg();
            msg.MessageType = Iso8583.MsgType._0100_AUTH_REQ;
            byte[] packed = msg.ToMsg();

            var unpacked = new BCDIsoMsg();
            unpacked.Unpack(packed, 0);
            Assert.AreEqual(Iso8583.MsgType._0100_AUTH_REQ, unpacked.MessageType);
        }
    }
}