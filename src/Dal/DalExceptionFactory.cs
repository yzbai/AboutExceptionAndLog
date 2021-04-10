using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal static class DalExceptionFactory
    {
        public static DalException OnMigrationError(int oldVersion, int newVersion, string sql, string? cause = null)
        {
            DalException exception = new DalException(DalErrorCodes.MigrationErr);

            exception.Data["Cause"] = cause;

            exception.Data["OldVersion"] = oldVersion;
            exception.Data["NewVersion"] = newVersion;
            exception.Data["Sql"] = sql;

            return exception;
        }

        public static DalException OnMigrationError(string sql, string? cause = null)
        {
            DalException exception = new DalException(DalErrorCodes.MigrationErr);

            exception.Data["Cause"] = cause;

            exception.Data["Sql"] = sql;

            return exception;
        }

        public static DalException OnNotFound(string? cause = null)
        {
            DalException exception = new DalException(DalErrorCodes.NotFoundErr);

            exception.Data["Cause"] = cause;

            return exception;
        }

    }
}
