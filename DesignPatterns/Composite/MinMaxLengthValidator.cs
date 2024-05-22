namespace DesignPatterns.Composite
{
    public class MinMaxLengthValidator : IValidator<string>
    {
        public int MaxLegth { get; set; }
        public int MinLength { get; set; }

        public MinMaxLengthValidator(int minLength = 2, int maxLength = 6)
        {
            MinLength = minLength;
            MaxLegth = maxLength;
        }

        public ValidatorResult Validate(string input)
        {
            try
            {
                return new ValidatorResult()
                {
                    IsValid = input.Length > MinLength && input.Length < MaxLegth,
                    Type = ValidatorTypes.MinMaxLength
                };
            }
            catch (Exception ex)
            {
                return new ValidatorResult()
                {
                    IsValid = false,
                    Type = ValidatorTypes.MinMaxLength,
                    Ex = ex
                };
            }

        }
    }
}
