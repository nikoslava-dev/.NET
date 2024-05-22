namespace DesignPatterns.Facade
{
    public class Bike : Car
    {
        public IBikeType BikeType { get; set; }
    }

    public class Car
    {
        public IModel Model { set; get; }

        public IColor Color { set; get; }

        public IBrand Brand { set; get; }
    }

    public interface IModel
    {
        string Name { get; }
    }

    public interface IColor
    {
        string Value { get; }
    }

    public interface IBrand
    {
        string FullName { get; }
    }

    public interface IBikeType
    {
        string FullName { get; }
    }
}
