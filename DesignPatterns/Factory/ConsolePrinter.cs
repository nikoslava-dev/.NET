namespace DesignPatterns.Factory
{
    public class ConsolePrinter : IPrinter
    {
        public async Task Print<T>(T content) where T : IContent
        {
            await Task.Run(() =>
                Console.WriteLine("Console Printer active {0}", content == null ? "empty" : content.PrintText)
            );
        }
    }
}
