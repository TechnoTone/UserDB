using System.Collections.Generic;

namespace UserDB.Repository
{
    public class InMemoryStore : IStore
    {
        private readonly List<SavedUser> savedUsers = new List<SavedUser>();

        public SavedUser AddUser(string emailAddress, string password)
        {
            var newUser = new SavedUser {EmailAddress = emailAddress, Password = password};
            savedUsers.Add(newUser);
            return newUser;
        }
    }
}
