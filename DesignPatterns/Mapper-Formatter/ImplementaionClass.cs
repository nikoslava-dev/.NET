namespace DesignPatterns.Mapper_Formatter
{
    public class ImplementaionClass
    {
        public void RunProcess()
        {
            List<UserDTO> usersDTO = new UserDtoListMapper().Map(GetUsersList());
        }

        private List<User> GetUsersList()
        {
            // service to get all db users
            return new List<User>();
        }
    }
}
