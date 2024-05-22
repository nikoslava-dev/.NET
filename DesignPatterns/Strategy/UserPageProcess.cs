namespace DesignPatterns.Strategy
{
    public class UserPageProcess : PageProcess<UserParams, List<User>, List<UserDetails>>
    {
        public UserPageProcess() : base(
            new UserLoadingStrategy(),
            new UserFormatingStrategy(),
            new UserPrintingStrategy())
        {
        }
    }
}
