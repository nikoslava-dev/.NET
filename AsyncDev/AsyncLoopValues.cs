namespace AsyncDev
{
    public class IEnumerbleApproach
    {
        public async void Main()
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: Start Process wait 10 seconds.....");

            foreach (var item in await FetchItems())
            {
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: {item}");
            }
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: End");

            // once the application starts, it waits for 10 seconds without any data, till the complete data is available.
            // Then, all of a sudden we can see the entire data points returned together.
        }

        private async Task<IEnumerable<int>> FetchItems()
        {
            List<int> Items = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(1000);
                Items.Add(i);
            }
            return Items;
        }
    }

    public class YieldApproach
    {
        public async void Main()
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: Start retrieve each item at a time but block the program");
            foreach (var item in FetchItems())
            {
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: {item}");
            }
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: End");

            // Notice that the FetchItems() method is now synchronous and cannot be awaited.
            // using yield, we can get each data point as soon as it arrives without having to wait for the complete data.This is good!
            // However, doing so means the FetchItems() method is now synchronous and even if the data fetch operation is async,
            // it will behave as a blocking call and we don’t get the advantages of fetching data asynchronously.
        }

        private IEnumerable<int> FetchItems()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                yield return i;
            }
        }
    }

    public class IAsyncEnumerableApproach
    {
        public async void Main()
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: Start retrieve each item at a time but NOT block program");
            await foreach (var item in FetchItems())
            {
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: {item}");
            }
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: End");

            // This will await the foreach loop itself rather than awaiting the FetchItems() method call within the foreach loop. 
            // instead of waiting for 10 seconds to get full data and then returning all data at once, we get each data point as it arrives.
            // On top of this, we get the advantage that this call is not a blocking one and has the advantages of asynchronous execution.
        }

        private async IAsyncEnumerable<int> FetchItems()
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }
    }
}
