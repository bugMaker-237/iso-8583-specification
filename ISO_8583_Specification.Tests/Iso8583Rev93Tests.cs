// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Iso8583Rev93Tests.cs" company="John Oxley && Etienne Yamsi">
//   2019
// </copyright>
// <summary>
//   The iso 8583 rev 93 tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ISO_8583_Specification.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The ISO 8583 rev 93 tests.
    /// </summary>
    [TestClass]
    public class Iso8583Rev93Tests
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets TestContext.
        /// </summary>
        public TestContext TestContext { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The test message pack length.
        /// </summary>
        [TestMethod]
        public void TestMessagePackLength()
        {
            var msg = new Iso8583Rev93();
            msg[2] = "58889212354567816";
            msg[3] = "270010";
            msg[102] = "9012273811";
            msg.MessageType = Iso8583Rev93.MsgType._1200_TRAN_REQ;

            var actual = msg.PackedLength;

            Assert.AreEqual(57, actual);
        }

        #endregion
    }
}