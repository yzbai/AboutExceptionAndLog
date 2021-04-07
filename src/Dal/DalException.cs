using System;

using Base;

namespace Dal
{
    public class DalException : ErrCodeException
    {
        public DalException(ErrCode errCode) : base(errCode)
        {
        }

        public DalException(ErrCode errCode, Exception? innerException) : base(errCode, innerException)
        {
        }
    }
}
