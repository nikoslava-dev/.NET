namespace DesignPatterns.Decorator
{
    public class Messenger : IMessenger
    {
        public string GetMessage()
        {
            return "My messege";
        }
    }

    public class ExtraMessenger : Messenger
    {
        public string Name { get; set; }
        public string GetMessage()
        {
            return $"{this.GetMessage()} extra {Name}";
        }
    }

    public class SuperMessenger : Messenger
    {
        public virtual string GetFullName()
        {
            return "My Name";
        }

        public string GetMessage()
        {
            return $"{this.GetMessage()} super {GetFullName()}";
        }
    }

    public class FullMessenger : SuperMessenger
    {
        public int Age { get; set; }

        public override string GetFullName()
        {
            return "Your Name";
        }

        public string GetMessage()
        {
            return $"{this.GetMessage()} full {GetFullName()} and age {Age}";
        }
    }
}
