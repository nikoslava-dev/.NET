namespace DesignPatterns.Disposable
{
    public class Car : IDisposable
    {
        public Car()
        {
            Console.WriteLine("Car constructor");
        }

        public void Dispose()
        {

            // you can clean up any resources here


            // NOT call finalizer
            GC.SuppressFinalize(this);

            Console.WriteLine("Car Disposed");
        }
    }
}
