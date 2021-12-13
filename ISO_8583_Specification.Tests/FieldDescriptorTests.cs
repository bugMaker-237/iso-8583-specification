// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FieldDescriptorTests.cs" company="John Oxley && Etienne Yamsi">
//   2019
// </copyright>
// <summary>
//   The field descriptor tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ISO_8583_Specification.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ISO_8583_Specification.Exceptions;
    using ISO_8583_Specification.FieldValidator;
    using ISO_8583_Specification.Formatter;
    using ISO_8583_Specification.LengthFormatters;

    /// <summary>
    /// The field descriptor tests.
    /// </summary>
    [TestClass]
    public class FieldDescriptorTests
    {
        #region Public Methods and Operators

        /// <summary>
        /// The test binary field must have hex validator.
        /// </summary>
        [TestMethod]
        public void TestBinaryFieldMustHaveHexValidator()
        {
            try
            {
                FieldDescriptor.Create(new FixedLengthFormatter(8), FieldValidators.None, Formatters.Binary);
                Assert.Fail("Binary formatter must have hex validator");
            }
            catch (FieldDescriptorException)
            {
            }
        }

        #endregion
    }
}