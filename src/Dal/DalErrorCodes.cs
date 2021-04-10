using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common;

namespace Dal
{
    internal static class DalErrorCodes
    {
        public static ErrorCode MigrationErr { get; } = new ErrorCode(1000, nameof(MigrationErr), "Migration Error.");
        public static ErrorCode NotFoundErr { get; } = new ErrorCode(1001, nameof(NotFoundErr), "Not Found Error");

        //......其他的
    }
}
