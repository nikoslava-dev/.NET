namespace DesignPatterns.Builder
{
    public class UserPartial
    {
        public UserPartial()
        {

        }

        public UserPartial(UserPartial user)
        {
            Personal = user.Personal;
        }

        public PersonalDetails Personal { get; set; }
    }

    public class UserFull : UserPartial
    {
        public UserFull() : base()
        {
        }

        public UserFull(UserPartial user) : base(user)
        {
        }

        public AddressDetails Address { get; set; }

        public ProfessionalDetails Professional { get; set; }
    }

    public class PersonalDetails
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class AddressDetails
    {
        public string City { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }
    }

    public class ProfessionalDetails
    {
        public string Possition { get; set; }

        public string Devision { get; set; }
    }
}
