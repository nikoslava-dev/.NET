namespace DesignPatterns.Mapper_Formatter
{
    public interface IMapper<Tin, Tout>
    {
        Tout Map(Tin input);
    }
}
