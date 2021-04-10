namespace IdentityService
{
    public interface IIdentityService
    {
        void SetNickName(long userId, string newNickName);
    }
}
