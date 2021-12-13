using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISO_8583_Specification.Tests.ValidatorTests
{
    /// <summary>
    ///   Summary description for AlphaNumericTests
    /// </summary>
    [TestClass]
    public class AlphaNumericValidatorTests : BaseValidatorTests
    {
        public AlphaNumericValidatorTests()
            : base(ISO_8583_Specification.FieldValidator.FieldValidators.AlphaNumeric)
        {
            ValidValues.Add("ab23cdef");
            ValidValues.Add("ABC23DEF");

            InvalidValues.Add("adsf7346,.");
            InvalidValues.Add("1324.234");
            InvalidValues.Add("ab23c def");
            InvalidValues.Add(".,?#'");
        }

        [TestMethod]
        public void TestAlphaNumericValidValues()
        {
            TestValidValues();
        }

        [TestMethod]
        public void TestAlphaNumericInvalidValues()
        {
            TestInvalidValues();
        }
    }
}