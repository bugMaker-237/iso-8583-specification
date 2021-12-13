// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BcdVariableFieldTests.cs" company="John Oxley && Etienne Yamsi">
//   2019
// </copyright>
// <summary>
//   Summary description for BcdVariableField
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ISO_8583_Specification.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ISO_8583_Specification.FieldValidator;
    using ISO_8583_Specification.Formatter;
    using ISO_8583_Specification.LengthFormatters;

    /// <summary>
    /// BCD Variable Field Tests
    /// </summary>
    [TestClass]
    public class BcdVariableFieldTests
    {
        #region Public Methods and Operators

        /// <summary>
        /// The test pack.
        /// </summary>
        [TestMethod]
        public void TestPack()
        {
            var f = new Field(2, FieldDescriptor.BcdVar(2, 15, Formatters.Bcd));
            f.Value = "77";
            var actual = f.ToMsg();
            var expected = new byte[2];
            expected[0] = 0x01;
            expected[1] = 0x77;
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// The unpack.
        /// </summary>
        [TestMethod]
        public void Unpack()
        {
            var f = new Field(
                2,
                FieldDescriptor.Create(
                    new VariableLengthFormatter(2, 15, Formatters.Bcd), FieldValidators.N, Formatters.Bcd));
            var msg = new byte[2];
            msg[0] = 0x02;
            msg[1] = 0x77;
            f.Unpack(msg, 0);
            var actual = f.Value;
            const string Expected = "77";
            Assert.AreEqual(Expected, actual);
        }

        #endregion
    }
}