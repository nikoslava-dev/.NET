namespace DesignPatterns.Facade
{
    public class VolvoBrand : IBrand
    {
        public string FullName { get { return "Volvo"; } }
    }

    public class SuzukiBrand : IBrand
    {
        public string FullName { get { return "Suzuki"; } }
    }

    public class SeatBrand : IBrand
    {
        public string FullName { get { return "Seat"; } }
    }

    public class BMWBrand : IBrand
    {
        public string FullName { get { return "BMW"; } }
    }
}
