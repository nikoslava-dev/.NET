namespace DesignPatterns.Mapper_Formatter
{
    public class UserDtoListMapper : IMapper<List<User>, List<UserDTO>>
    {
        public List<UserDTO> Map(List<User> input)
        {
            var users = new List<UserDTO>();
            var mapper = new UserDtoMapper();

            foreach (var item in input)
            {
                users.Add(mapper.Map(item));
            }

            return users;
        }
    }

    public class UserDtoMapper : IMapper<User, UserDTO>
    {
        public UserDTO Map(User input)
        {
            var user = new UserDTO();
            user.FullName = $"{input.FirstName} {input.LastName}";
            user.Age = DateTime.Now.Year - input.Birthdate.Year;

            return user;
        }
    }
}
