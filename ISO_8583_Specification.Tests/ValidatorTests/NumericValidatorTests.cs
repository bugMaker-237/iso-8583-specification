using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISO_8583_Specification.Tests.ValidatorTests
{
    /// <summary>
    ///   Summary description for NumericValidatorTests
    /// </summary>
    [TestClass]
    public class NumericValidatorTests : BaseValidatorTests
    {
        public NumericValidatorTests()
            : base(ISO_8583_Specification.FieldValidator.FieldValidators.Numeric)
        {
            ValidValues.Add("0123456789");

            InvalidValues.Add("ABCDEF");
            InvalidValues.Add("abcdef");
            InvalidValues.Add("123468dfc");
            InvalidValues.Add(" ");
            InvalidValues.Add("123abcdefg");
            InvalidValues.Add("./'[]");
            InvalidValues.Add("\t");
            InvalidValues.Add("\n");
        }

        [TestMethod]
        public void TestNumericValidValues()
        {
            TestValidValues();
        }

        [TestMethod]
        public void TestNumericInvalidValues()
        {
            TestInvalidValues();
        }
    }
}