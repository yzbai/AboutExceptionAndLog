using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class DbMigration
    {
        public static void Migration(int oldVersion, int newVersion, string sql)
        {
            //.. shit happened

            throw ExceptionFactory.OnMigrationError(oldVersion, newVersion, sql, "shit happens");
        }
    }
}
