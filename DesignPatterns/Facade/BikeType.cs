namespace DesignPatterns.Facade
{
    public class ExtremeBike : IBikeType
    {
        public string FullName { get { return "Extreme"; } }
    }

    public class MountainBike : IBikeType
    {
        public string FullName { get { return "Mountain"; } }
    }

    public class StreetBike : IBikeType
    {
        public string FullName { get { return "Street"; } }
    }

    public class SportBike : IBikeType
    {
        public string FullName { get { return "Sport"; } }
    }
}
