namespace DesignPatterns.Composite
{
    public class ValidatorResult
    {
        public bool IsValid { get; set; }

        public ValidatorTypes Type { get; set; }

        public Exception Ex { get; set; }
    }
}
