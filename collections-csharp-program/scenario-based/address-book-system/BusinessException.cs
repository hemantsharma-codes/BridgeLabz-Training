    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class BusinessException : Exception
    {
        public BusinessErrorCode ErrorCode { get; }

        public BusinessException(BusinessErrorCode errorCode, string message) : base(message)
        {
            this.ErrorCode = errorCode;
        }

    }
}