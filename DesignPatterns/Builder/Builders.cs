namespace DesignPatterns.Builder
{
    public class UserPartialBuilder : IBuilder<UserPartial>
    {
        public UserPartial Build()
        {
            var user = new UserPartial();
            user.Personal = new PersonalDetailsBuilder().Build();
            return user;
        }
    }

    public class UserFullBuilder : IBuilder<UserFull>
    {
        public UserFull Build()
        {
            UserFull user = new UserFull(new UserPartialBuilder().Build());
            user.Address = new AddressDetailsBuilder().Build();
            user.Professional = new ProfessionalDetailsBuilder().Build();
            return user;
        }
    }

    public class PersonalDetailsBuilder : IBuilder<PersonalDetails>
    {
        public PersonalDetails Build()
        {
            // service to get personal details
            return new PersonalDetails();
        }
    }

    public class AddressDetailsBuilder : IBuilder<AddressDetails>
    {
        public AddressDetails Build()
        {
            // service to get address details
            return new AddressDetails();
        }
    }

    public class ProfessionalDetailsBuilder : IBuilder<ProfessionalDetails>
    {
        public ProfessionalDetails Build()
        {
            // service to get prof details
            return new ProfessionalDetails();
        }
    }
}
