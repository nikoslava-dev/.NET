namespace AsyncDev
{
    public class ProcessMultipleRequests
    {
        public async void RunProcess()
        {
            var urls = new List<string>
            {
                "https://www.naveedulhaq.com/index.php/dot-net-core/combining-async-and-yield-in-c/",
                "https://docs.mapbox.com/mapbox-gl-js/api/",
                "https://developer.mozilla.org/en-US/docs/Web/API/MediaDevices/getUserMedia"
            };

            await foreach (var content in AsyncRequests(urls))
            {
                // Process the content asynchronously
                Console.WriteLine($"------------------------------------------------ {content}");
            }

            Console.WriteLine($"end process");
        }

        public async IAsyncEnumerable<string> AsyncRequests(IEnumerable<string> urls)
        {
            foreach (var url in urls)
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();

                yield return content;
            }
        }
    }
}
