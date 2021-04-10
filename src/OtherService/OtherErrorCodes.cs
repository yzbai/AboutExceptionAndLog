
using Common;

namespace OtherService
{
    internal static class OtherErrorCodes
    {
        public static ErrorCode UnkownError { get; set; } = new ErrorCode(4000, nameof(UnkownError), "UnKown error.");

        //other....
    }
}
