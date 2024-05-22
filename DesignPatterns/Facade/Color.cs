namespace DesignPatterns.Facade
{
    public class BlueColor : IColor
    {
        public string Value { get { return "Blue"; } }
    }

    public class RedColor : IColor
    {
        public string Value { get { return "Red"; } }
    }

    public class GreenColor : IColor
    {
        public string Value { get { return "Green"; } }
    }

    public class BrownColor : IColor
    {
        public string Value { get { return "Brown"; } }
    }
}
