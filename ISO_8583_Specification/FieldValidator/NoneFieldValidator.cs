namespace ISO_8583_Specification.FieldValidator
{
    /// <summary>
    ///   Field formatter that always returns true
    /// </summary>
    public class NoneFieldValidator : IFieldValidator
    {
        #region IFieldValidator Members

        /// <summary>
        ///   Description of the validator
        /// </summary>
        public string Description
        {
            get { return "none"; }
        }

        /// <summary>
        ///   Validates the format of the given string value
        /// </summary>
        /// <param name = "value">Value to validate</param>
        /// <returns>true if valid, false otherwise</returns>
        public bool IsValid(string value)
        {
            return true;
        }

        #endregion
    }
}