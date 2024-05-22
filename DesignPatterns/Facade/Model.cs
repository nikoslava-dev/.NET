namespace DesignPatterns.Facade
{
    public class SuzukiModel : IModel
    {
        public string Name { get { return "CrossOver"; } }
    }

    public class VolvoModel : IModel
    {
        public string Name { get { return "80T"; } }
    }

    public class SeatModel : IModel
    {
        public string Name { get { return "Ibiza"; } }
    }
}
