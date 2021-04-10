using System;

namespace Common
{
    public class ErrorCodeException : Exception
    {
        public ErrorCodeException(ErrorCode errCode) : base(errCode?.Message)
        {
            ErrCode = errCode;
        }

        public ErrorCodeException(ErrorCode errCode, Exception? innerException) : base(errCode?.Message, innerException)
        {
            ErrCode = errCode;
        }

        public ErrorCode ErrCode
        {
            get
            {
                return (ErrorCode)Data[nameof(ErrCode)]!;
            }
            private set
            {
                Data[nameof(ErrCode)] = value;
            }
        }
    }
}
