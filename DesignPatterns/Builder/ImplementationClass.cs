namespace DesignPatterns.Builder
{
    public class ImplementationClass
    {
        public void RunProcess()
        {
            UserPartial userPartial = new UserPartialBuilder().Build();
            UserPartial user = new UserFullBuilder().Build();
        }
    }
}
