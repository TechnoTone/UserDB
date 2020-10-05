using FluentAssertions;
using NUnit.Framework;
using UserDB.Website.API;

namespace UserDB.Testing
{
    public class UserControllerTests
    {
        [Test]
        public void SaveUserDoesAddToRepository()
        {
            var testStore = new TestStore();
            var api = new UsersController(testStore);

            api.Save(new NewUserRequest {EmailAddress = "test", Password = "test"});

            testStore.GetAll().Count.Should().Be(1);
            testStore.GetAll()[0].EmailAddress.Should().Be("test");
            testStore.GetAll()[0].Password.Should().Be("test");
        }

    }
}
