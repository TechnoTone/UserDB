namespace UserDB.Repository
{
    public interface IStore
    {
        SavedUser AddUser(string emailAddress, string password);
    }
}
