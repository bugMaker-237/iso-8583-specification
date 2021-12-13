using System;

namespace ISO_8583_Specification.Exceptions
{
    /// <summary>
    /// Used to show a format exception in building the ISO message
    /// </summary>
    public class FormatException : ApplicationException
    {
        /// <summary>
        /// Creates a new instance of the FormatException class
        /// </summary>
        /// <param name="message">Message to include in the exception</param>
        public FormatException(string message)
            : base(message)
        {
        }
    }
}