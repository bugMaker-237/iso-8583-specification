// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FixedLengthValidatorTests.cs" company="John Oxley && Etienne Yamsi">
//   2019
// </copyright>
// <summary>
//   Summary description for FixedLengthValidatorTests
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ISO_8583_Specification.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ISO_8583_Specification.LengthValidators;

    /// <summary>
    /// Fixed Length Validator Tests
    /// </summary>
    [TestClass]
    public class FixedLengthValidatorTests
    {
        #region Public Properties

        /// <summary>
        ///  Gets or sets the test context which provides information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The test correct length.
        /// </summary>
        [TestMethod]
        public void TestCorrectLength()
        {
            var val = new FixedLengthValidator(6);
            var actual = val.IsValid("132456");
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// The test too long.
        /// </summary>
        [TestMethod]
        public void TestTooLong()
        {
            var val = new FixedLengthValidator(6);
            var actual = val.IsValid("1324567");
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// The test too short.
        /// </summary>
        [TestMethod]
        public void TestTooShort()
        {
            var val = new FixedLengthValidator(6);
            var actual = val.IsValid("13245");
            Assert.AreEqual(false, actual);
        }

        #endregion
    }
}