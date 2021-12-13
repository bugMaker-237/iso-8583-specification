using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISO_8583_Specification.Tests.ValidatorTests
{
    /// <summary>
    ///   Summary description for AlphaOrNumericTests
    /// </summary>
    [TestClass]
    public class AlphaOrNumericValidatorTests : BaseValidatorTests
    {
        public AlphaOrNumericValidatorTests()
            : base(ISO_8583_Specification.FieldValidator.FieldValidators.AlphaOrNumeric)
        {
            ValidValues.Add("1234567890");
            ValidValues.Add("ABCdef");

            InvalidValues.Add("1234a");
            InvalidValues.Add("1324.234");
            InvalidValues.Add("abcdef1");
            InvalidValues.Add("ZYX ");
            InvalidValues.Add(".,?#'");
        }

        [TestMethod]
        public void TestAlphaOrNumericValidValues()
        {
            TestValidValues();
        }

        [TestMethod]
        public void TestAlphaOrNumericInvalidValues()
        {
            TestInvalidValues();
        }
    }
}