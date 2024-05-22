
namespace DesignPatterns.Factory
{
    public class HTMLPrinter : IPrinter
    {
        public async Task Print<T>(T content) where T : IContent
        {
            await Task.Run(() =>
                Console.WriteLine("HTML Printer active {0}", content == null ? "empty" : content.PrintText)
            );
        }
    }
}
