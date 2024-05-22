namespace DesignPatterns.Strategy
{
    public class UserParams
    {
        public int Skip { get; set; }

        public int Top { get; set; }
    }

    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class UserDetails
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        public string Role { get; set; }
    }
}
