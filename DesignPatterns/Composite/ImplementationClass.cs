namespace DesignPatterns.Composite
{
    public class ImplementationClass
    {
        void ValidateInput(string input)
        {
            ValidationComposit<string> composite = new ValidationComposit<string>();
            List<IValidator<string>> validators = new List<IValidator<string>>();
            validators.Add(new RequeredValidator());
            validators.Add(new MinMaxLengthValidator(3, 5));
            validators.Add(new RegExValidator(@"^[a-zA-Z]+$"));

            List<ValidatorResult> result = composite.Validate(validators, input);
            foreach (var validatorResult in result)
            {
                Console.WriteLine($"validator type: {validatorResult.Type} - is valid: {validatorResult.IsValid}");
            }
        }
    }
}
