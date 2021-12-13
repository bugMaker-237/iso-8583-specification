using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISO_8583_Specification
{
    /// <summary>
    /// 
    /// </summary>
    public interface IResponseCodes
    {
        /// <summary>
        /// PROCSSED OK
        /// </summary>
        string PROCSSED_OK { get; }

        /// <summary>
        /// INTERNAL ERROR
        /// </summary>
        string INTERNAL_ERROR { get; }

        /// <summary>
        /// Low Balance
        /// </summary>
        string LOW_BALANCE { get; }
        
        /// <summary>
        /// Invalid Account
        /// </summary>
        string INVALID_ACCOUNT { get; }

        /// <summary>
        /// Account Inactive
        /// </summary>
        string ACCOUNT_INACTIVE { get; }

        /// <summary>
        /// Already reverssed
        /// </summary>
        string ALREADY_REVERSED { get; }

        /// <summary>
        /// Already processed
        /// </summary>
        string ALREADY_PROCESSED { get; }

        /// <summary>
        /// Incorrect message format
        /// </summary>
        string INCORRECT_MESSAGE_FORMAT { get; }
    }
}
