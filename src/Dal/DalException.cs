using System;

using Common;

namespace Dal
{
    public class DalException : ErrorCodeException
    {
        public DalException(ErrorCode errCode) : base(errCode)
        {
        }

        public DalException(ErrorCode errCode, Exception? innerException) : base(errCode, innerException)
        {
        }
    }
}
