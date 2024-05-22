namespace DesignPatterns.Adapter
{
    public class OldToNewAdapter : INewUser
    {
        private readonly OldUser _oldUser;

        public OldToNewAdapter(OldUser adaptee)
        {
            _oldUser = adaptee;
        }

        public void PrintUser()
        {
            _oldUser.PrintOldUser();
        }
    }
}
