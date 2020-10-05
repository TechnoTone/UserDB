using System.Collections.Generic;
using UserDB.Repository;

namespace UserDB.Testing
{
    public class TestStore : IStore
    {
        private readonly List<SavedUser> savedUsers = new List<SavedUser>();

        public List<SavedUser> GetAll() => savedUsers;

        public SavedUser AddUser(string emailAddress, string password)
        {
            var newUser = new SavedUser {EmailAddress = emailAddress, Password = password};
            savedUsers.Add(newUser);
            return newUser;
        }
    }
}
