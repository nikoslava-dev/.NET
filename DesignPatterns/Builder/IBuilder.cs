namespace DesignPatterns.Builder
{
    public interface IBuilder<Tout>
    {
        Tout Build();
    }
}
