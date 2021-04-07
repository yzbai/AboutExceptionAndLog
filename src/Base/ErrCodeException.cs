using System;

namespace Base
{
    public class ErrCodeException : Exception
    {
        public ErrCodeException(ErrCode errCode) : base(errCode?.Message)
        {
            ErrCode = errCode;
        }

        public ErrCodeException(ErrCode errCode, Exception? innerException) : base(errCode?.Message, innerException)
        {
            ErrCode = errCode;
        }

        public ErrCode ErrCode
        {
            get
            {
                return (ErrCode)Data[nameof(ErrCode)]!;
            }
            private set
            {
                Data[nameof(ErrCode)] = value;
            }
        }
    }
}
