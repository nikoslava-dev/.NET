namespace DesignPatterns.Mapper_Formatter
{
    public class User
    {
        public int Id { get; set; }

        public int FirstName { get; set; }

        public int LastName { get; set; }

        public DateTime Birthdate { get; set; }
    }

    public class UserDTO
    {
        public string FullName { get; set; }

        public int Age { get; set; }
    }
}
