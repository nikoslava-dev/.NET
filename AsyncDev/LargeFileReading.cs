namespace AsyncDev
{
    public class LargeFileReading
    {
        public async Task RunProcess()
        {
            string path = @"C:\Users\User\Documents\Visual Studio 2008\Projects\AsyncDev\largeFile.txt";
            await foreach (var content in ReadLinesAsync(path))
            {
                // Process the content asynchronously
                Console.WriteLine($"--- {content}");
            }

            Console.WriteLine($"end process");
        }

        public async IAsyncEnumerable<string> ReadLinesAsync(string filePath)
        {
            using var reader = new StreamReader(filePath);
            string line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                yield return line;
            }
        }
    }
}
