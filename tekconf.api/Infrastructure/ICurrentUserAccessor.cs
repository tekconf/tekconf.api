namespace tekconf.api.Infrastructure
{
    public interface ICurrentUserAccessor
    {
        string GetCurrentUsername();
    }
}