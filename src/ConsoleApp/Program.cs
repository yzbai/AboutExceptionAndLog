using System;

using Dal;

using Serilog;
using Serilog.Exceptions;
using Serilog.Formatting.Json;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            using var logger = new LoggerConfiguration()
                .Enrich.WithExceptionDetails()
                .WriteTo.Console(new JsonFormatter())
                .CreateLogger();

            try
            {
                DbMigration.Migration(1, 2, "wrong sql");
            }
            catch (DalException ex)
            {
                logger.Error(ex, "Migration Error.");
            }             
        }
    }
}

/*

输出

{
    "Timestamp": "2021-04-07T14:02:19.6034562+08:00", 
    "Level": "Error", 
    "MessageTemplate": "Migration Error.", 
    "Exception": "Dal.DalException: Migration Error.
       at Dal.DbMigration.Migration(Int32 oldVersion, Int32 newVersion, String sql) in C:\\Project\\blogs_project\\AboutExceptionAndLog\\src\\Dal\\DbMigration.cs:line 15
       at ConsoleApp.Program.Main() in C:\\Project\\blogs_project\\AboutExceptionAndLog\\src\\ConsoleApp\\Program.cs:line 22", 
    "Properties": {
        "ExceptionDetail": {
            "Data": {
                "ErrCode": {
                    "Id": 1, 
                    "Name": "MigrationErr", 
                    "Message": "Migration Error.", 
                    "$id": "1"
                }, 
                "OldVersion": 1, 
                "NewVersion": 2, 
                "Sql": "wrong sql", 
                "Cause": "shit happens"
            }, 
            "HResult": -2146233088, 
            "Message": "Migration Error.", 
            "Source": "Dal", 
            "ErrCode": {
                "$ref": "1"
            }, 
            "Type": "Dal.DalException"
        }
    }
}

 */
