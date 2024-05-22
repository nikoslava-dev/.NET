namespace AsyncDev
{
    public class BestPractices
    {
        // Use async and await to perform I/O-bound operations asynchronously.
        public async Task<string> GetWebPageAsync(string url)
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(url);
        }

        // Use ConfigureAwait(false) to improve performance when you don’t need to resume on the original context.
        public async Task<string> GetPageAsync(string url)
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(url).ConfigureAwait(false);
        }

        // Use the CancellationToken.
        // ThrowIfCancellationRequested method to check for cancellation and throw an exception if cancellation has been requested.
        public async Task<string> GetWebPageAsync(string url, CancellationToken cancellationToken)
        {
            using var client = new HttpClient();
            cancellationToken.ThrowIfCancellationRequested();
            return await client.GetStringAsync(url);
        }

        // Use the CancellationToken.
        // Register method to register a delegate to be called when the token is cancelled.
        public async Task<string> GetWebAsync(string url, CancellationToken cancellationToken)
        {
            using var client = new HttpClient();
            cancellationToken.Register(() => client.CancelPendingRequests());
            return await client.GetStringAsync(url);
        }

        // Use the CancellationTokenSource.
        // CancelAfter method to automatically cancel a task after a specified time period.
        public async Task<string> GetWebPageAsync(string url, int timeoutInSeconds)
        {
            using var client = new HttpClient();
            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(timeoutInSeconds));
            return await client.GetStringAsync(url, cts.Token);
        }

        // Use the Task.
        // WhenAll method to execute multiple tasks concurrently.
        public async Task<string[]> GetWebPagesAsync(List<string> urls)
        {
            IEnumerable<Task<string>> tasks = urls.Select(url => GetWebPageAsync(url));
            return await Task.WhenAll(tasks);
        }

        public async Task DoSomethingAsync(Action<string> DoSomething1Async, Action<string> DoSomething2Async)
        {
            var task1 = Task.Run(() => DoSomething1Async("1"));
            var task2 = Task.Run(() => DoSomething2Async("2"));
            await Task.WhenAll(task1, task2);
        }

        // Use the Task.
        // WhenAny method to await the first task to complete.
        public async Task<string> GetFirstWebPageAsync(List<string> urls)
        {
            var tasks = urls.Select(url => GetWebPageAsync(url));
            var completedTask = await Task.WhenAny(tasks);
            return await completedTask;
        }

        // Use the async void keyword only for event handlers, and avoid using it in other methods.
        public async void Button_Click(object sender, EventArgs e)
        {
            var result = await GetWebPageAsync("http://www.example.com");
            Console.WriteLine(result);
        }
    }
}
