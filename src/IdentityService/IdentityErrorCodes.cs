using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common;

namespace IdentityService
{
    internal static class IdentityErrorCodes
    {
        public static ErrorCode SecurityStampError { get; set; } = new ErrorCode(3000, nameof(SecurityStampError), "User Security Stamp Error.");

        //others ...
    }
}
