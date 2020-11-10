namespace TestDemo
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddMoney(int userId, long amount)
        {
            var user = _userRepository.GetUserById(userId);
            user.AddMoney(new Money(amount));
        }

        public void SubstractMoney(int userId, long amount)
        {

        }
    }
}