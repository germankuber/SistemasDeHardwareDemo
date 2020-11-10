using System.Linq;
using Xunit;

namespace TestDemo
{
    public class UserServiceShould
    {

        [Fact]
        public void Unit_Test()
        {
            var user = new User("Nombre", 1);
            var moneyToAdd = new Money(11);
            user.AddMoney(moneyToAdd);

            Assert.Equal(moneyToAdd, user.Money.First());
        }

        [Fact]
        public void Unit_Test2()
        {
            var user = new User("Nombre", 1);
            var userService = new UserService(new UserRepositoryMock(user));
            userService.AddMoney(1, 111);

            Assert.Equal(111, user.Money.First().Value);
        }


        [Fact]
        public void Integration_Test()
        {
            var repository = new UserRepository();
            var userService = new UserService(repository);
            userService.AddMoney(1, 111);


            var user = repository.GetUserById(1);

            Assert.Equal(111, user.Money.First().Value);
        }
    }
}