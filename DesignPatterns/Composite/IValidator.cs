namespace DesignPatterns.Composite
{
    public interface IValidator<T>
    {
        ValidatorResult Validate(T input);
    }
}
