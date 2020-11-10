namespace TestDemo
{
    public class UserRepositoryMock : IUserRepository
    {
        private readonly User _user;

        public UserRepositoryMock(User user)
        {
            _user = user;
        }

        public User GetUserById(int id) => _user;
    }
}