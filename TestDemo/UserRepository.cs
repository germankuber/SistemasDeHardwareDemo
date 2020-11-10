namespace TestDemo
{
    public class UserRepository : IUserRepository
    {
        private User _user;

        public UserRepository()
        {
            _user = new User("Test");
        }

        public User GetUserById(int id)
        {
            _user.Id = id;
            return _user;
        }

    }
}