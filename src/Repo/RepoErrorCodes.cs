using System;

using Common;

namespace Repo
{
    internal class RepoErrorCodes
    {
        public static ErrorCode CacheNotAvailableError { get; set; } = new ErrorCode(2000, nameof(CacheNotAvailableError), "Cache not avaliable now.");
        //...others
    }
}
