using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISO_8583_Specification.Tests.ValidatorTests
{
    /// <summary>
    /// Summary description for HexValidatorTests
    /// </summary>
    [TestClass]
    public class HexValidatorTests : BaseValidatorTests
    {
        public HexValidatorTests()
            : base(ISO_8583_Specification.FieldValidator.FieldValidators.Hex)
        {
            ValidValues.Add("0123456789");
            ValidValues.Add("ABCDEF");
            ValidValues.Add("abcdef");
            ValidValues.Add("123468dfc");

            InvalidValues.Add(" ");
            InvalidValues.Add("123abcdefg");
            InvalidValues.Add("./'[]");
            InvalidValues.Add("\t");
            InvalidValues.Add("\n");
        }

        [TestMethod]
        public void TestHexValidValues()
        {
            TestValidValues();
        }

        [TestMethod]
        public void TestHexInvalidValues()
        {
            TestInvalidValues();
        }
    }
}
