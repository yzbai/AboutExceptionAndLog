using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base;

namespace Dal
{
    public static class DalErrCodes
    {
        public static ErrCode MigrationErr { get; } = new ErrCode(1, nameof(MigrationErr), "Migration Error.");
        public static ErrCode NotFoundErr { get; } = new ErrCode(2, nameof(NotFoundErr), "Not Found Error");

        //......其他的
    }
}
