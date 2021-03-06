using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISO_8583_Specification.Tests.ValidatorTests
{
    /// <summary>
    /// Summary description for NoneValidatorTests
    /// </summary>
    [TestClass]
    public class NoneValidatorTests : BaseValidatorTests
    {
        public NoneValidatorTests()
            : base(ISO_8583_Specification.FieldValidator.FieldValidators.None)
        {
            ValidValues.Add("0123456789");
            ValidValues.Add("ABCDEF");
            ValidValues.Add("abcdef");
            ValidValues.Add("123468dfc");
            ValidValues.Add(" ");
            ValidValues.Add("123abcdefg");
            ValidValues.Add("./'[]");
            ValidValues.Add("\t");
            ValidValues.Add("\n");
        }

        [TestMethod]
        public void TestNoneValidValues()
        {
            TestValidValues();
        }

        [TestMethod]
        public void TestNoneInvalidValues()
        {
            TestInvalidValues();
        }
    }
}
