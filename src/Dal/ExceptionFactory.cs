using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class ExceptionFactory
    {
        public static DalException OnMigrationError(int oldVersion, int newVersion, string sql, string? cause = null)
        {
            DalException exception = new DalException(DalErrCodes.MigrationErr);

            exception.Data["OldVersion"] = oldVersion;
            exception.Data["NewVersion"] = newVersion;
            exception.Data["Sql"] = sql;
            exception.Data["Cause"] = cause;

            return exception;
        }

        public static DalException OnMigrationError(string sql, string? cause = null)
        {
            DalException exception = new DalException(DalErrCodes.MigrationErr);

            exception.Data["Sql"] = sql;
            exception.Data["Cause"] = cause;

            return exception;
        }

        public static DalException OnNotFound(string? cause = null)
        {
            DalException exception = new DalException(DalErrCodes.NotFoundErr);

            exception.Data["Cause"] = cause;

            return exception;
        }

    }
}
