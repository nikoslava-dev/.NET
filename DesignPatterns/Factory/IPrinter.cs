namespace DesignPatterns.Factory
{
    public interface IPrinter
    {
        Task Print<T>(T content) where T : IContent;
    }

    public interface IContent
    {
        public string PrintText { get; }
    }
}
