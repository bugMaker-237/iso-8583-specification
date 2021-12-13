using System;

namespace ISO_8583_Specification.Exceptions
{
    ///<summary>
    ///  Exception thrown for constructing a field descriptor
    ///</summary>
    public class FieldDescriptorException : ApplicationException
    {
        /// <summary>
        ///   Initialises a new instance of the FieldDescriptorException class
        /// </summary>
        /// <param name = "message">A message that describes the error</param>
        public FieldDescriptorException(string message) : base(message)
        {
        }
    }
}