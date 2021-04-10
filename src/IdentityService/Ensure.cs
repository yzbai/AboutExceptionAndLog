using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService
{
    internal static class Ensure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA1801:Review unused parameters", Justification = "<Pending>")]
        public static void NickNameNotExisted(string newNickName)
        {
            bool alreadyExisted = true;

            // Some Check
            
            if(alreadyExisted)
            {
                throw IdentityExceptionFactory.NickNameExisted();
            }
        }

        public static T NotNull<T>([NotNull]T? obj, string paramName)
            where T : class
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }
            return obj;
        }

        public static string NotNullOrEmpty([NotNull]string? obj, string paramName)
        {
            if (string.IsNullOrEmpty(obj))
            {
                throw new ArgumentException("Value cannot be null or an empty string.", paramName);
            }
            return obj;
        }
    }
}
