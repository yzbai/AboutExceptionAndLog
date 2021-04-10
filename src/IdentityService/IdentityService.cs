namespace IdentityService
{
    internal class IdentityService : IIdentityService
    {
        public void SetNickName(long userId, string newNickName)
        {
            //....
            Ensure.NickNameNotExisted(newNickName);
            //....
        }
    }
}
