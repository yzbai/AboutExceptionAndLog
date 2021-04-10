using System;

using Common;

namespace IdentityService
{
    public class IdentityException : ErrorCodeException
    {
        public IdentityException(ErrorCode errCode) : base(errCode)
        {
        }

        public IdentityException(ErrorCode errCode, Exception innerException) : base(errCode, innerException)
        {
        }
    }
}
