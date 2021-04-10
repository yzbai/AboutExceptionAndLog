
using System;

using Common;

namespace OtherService
{
    internal class OtherException : ErrorCodeException
    {
        public OtherException(ErrorCode errCode) : base(errCode)
        {
        }

        public OtherException(ErrorCode errCode, Exception innerException) : base(errCode, innerException)
        {
        }
    }
}
