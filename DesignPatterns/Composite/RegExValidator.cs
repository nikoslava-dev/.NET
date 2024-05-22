using System.Text.RegularExpressions;

namespace DesignPatterns.Composite
{
    public class RegExValidator : IValidator<string>
    {
        public string Expration { get; set; }

        public RegExValidator(string expration)
        {
            Expration = expration;
        }

        public ValidatorResult Validate(string input)
        {
            try
            {
                return new ValidatorResult()
                {
                    IsValid = Regex.IsMatch(input, Expration),
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
