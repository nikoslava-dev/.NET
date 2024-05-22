namespace DesignPatterns.Composite
{
    public interface IValidatorComposit<T>
    {
        List<ValidatorResult> Validate(List<IValidator<T>> validators, T input);
    }

    public class ValidationComposit<Tin> : IValidatorComposit<Tin>
    {
        public List<ValidatorResult> Validate(List<IValidator<Tin>> validators, Tin input)
        {
            List<ValidatorResult> result = new List<ValidatorResult>();
            foreach (var validator in validators)
            {
                ValidatorResult res = validator.Validate(input);
                result.Add(res);
            }

            return result;
        }
    }
}
