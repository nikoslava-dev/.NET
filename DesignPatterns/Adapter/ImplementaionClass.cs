namespace DesignPatterns.Adapter
{
    public class ImplementaionClass
    {
        public void RunProcess()
        {
            OldUser oldUser = new OldUser() { Id = 1, Name = "Vasya" };
            INewUser target = new OldToNewAdapter(oldUser);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            target.PrintUser();
        }
    }

    /*    OldUser class can be incompatible with the new code.
    But with OldToNewAdapter we can use INewUser and call OldUser method.*/
}
