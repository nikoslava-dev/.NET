
namespace DesignPatterns.Factory
{
    public class FilePrinter : IPrinter
    {
        public async Task Print<T>(T content) where T : IContent
        {
            await Task.Run(() =>
                Console.WriteLine("File Printer active {0}", content == null ? "empty" : content.PrintText)
            );
        }
    }
}
