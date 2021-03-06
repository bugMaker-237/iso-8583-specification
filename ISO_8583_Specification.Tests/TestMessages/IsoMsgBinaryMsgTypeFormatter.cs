// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IsoMsgBinaryMsgTypeFormatter.cs" company="John Oxley && Etienne Yamsi">
//   2019
// </copyright>
// <summary>
//   An ISO 8583 Message with an ASCII Message Type formatter
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ISO_8583_Specification.Tests.TestMessages
{
    using ISO_8583_Specification.Formatter;

    /// <summary>
    /// An ISO 8583 Message with an ASCII Message Type formatter
    /// </summary>
    public class IsoMsgBinaryMsgTypeFormatter : Iso8583
    {
        #region Constants and Fields

        /// <summary>
        /// The template.
        /// </summary>
        private static readonly Template MsgTemplate;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="IsoMsgBinaryMsgTypeFormatter"/> class.
        /// </summary>
        static IsoMsgBinaryMsgTypeFormatter()
        {
            // Get the default template for the Iso8583 class
            MsgTemplate = GetDefaultIso8583Template();

            MsgTemplate.MsgTypeFormatter = new BinaryFormatter();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IsoMsgBinaryMsgTypeFormatter"/> class.
        /// </summary>
        public IsoMsgBinaryMsgTypeFormatter()
            : base(MsgTemplate)
        {
        }

        #endregion
    }
}