namespace DesignPatterns.Disposable
{
    public class CarOptional : IDisposable
    {
        private bool isDisposed = false;

        public CarOptional()
        {
            Console.WriteLine("Car constructor");
        }

        /// <summary>
        /// use destructor to release this unmanaged resource Just as you would use the constructor to initialize any unmanaged resource
        /// after compile destructor will become an overridden version of Finalize method
        /// implement both Finalize method (destructor) and IDisposable. 
        /// Whenever a user forgets to call Dispose method, eventually (when GC collects), your finalizer will be called
        /// </summary>
        ~CarOptional()
        {
            Console.WriteLine("Car DESTRUCTOR");
            Dispose(false);
        }

        // IDisposable Dispose method
        /// implement both Finalize method (destructor) and IDisposable. 
        /// Whenever a user forgets to call Dispose method, eventually (when GC collects), your finalizer will be called
        public void Dispose()
        {
            Dispose(true);

            // NOT call finalizer
            GC.SuppressFinalize(this);
        }

        /// implement both Finalize method (destructor) and IDisposable. 
        /// Whenever a user forgets to call Dispose method, eventually (when GC collects), your finalizer will be called
        protected void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    // you can clean up any managed code here
                }

                // clean up unmanaged resources here
                isDisposed = true;
            }
        }
    }
}
