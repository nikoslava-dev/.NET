namespace DesignPatterns.Composite
{
    public class RequeredValidator : IValidator<string>
    {
        public ValidatorResult Validate(string input)
        {
            try
            {
                return new ValidatorResult()
                {
                    IsValid = input != null && input.Trim() != string.Empty,
                    Type = ValidatorTypes.Requered
                };
            }
            catch (Exception ex)
            {
                return new ValidatorResult()
                {
                    IsValid = false,
                    Type = ValidatorTypes.Requered,
                    Ex = ex
                };
            }

        }
    }
}
