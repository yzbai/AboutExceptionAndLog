using System;

using Common;

namespace Repo
{
    public class RepoException : ErrorCodeException
    {
        public RepoException(ErrorCode errCode) : base(errCode)
        {
        }

        public RepoException(ErrorCode errCode, Exception innerException) : base(errCode, innerException)
        {
        }
    }
}
