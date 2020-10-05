# UserDB

A simple webpage and API for entering and saving user's email address  
and password.

#### Comments / Next steps

1. **Async** : currently all the code is synchronous. This has the
   potential to cause performance bottlenecks for any long-running
   tasks. Currently this is not an issue but for real-world systems
   it often is important.

2. **Persistence** : There is currently no long-term data persistence.
   The "database" for now is just an in-memory list. However, the
   persistence layer has been abstracted to a separate layer so
   swapping out the InMemoryStore for a proper database/ORM solution
   is very trivial.

3. **Testing** : There is a test project with a unit test showing how to
   use the included 'TestStore' but there are currently no tests for the
   API endpoint itself. For proper integration testing API tests would
   be useful to test, for example, validation.

4. **SQL** : I didn't create a local SQL Database as I was limited by
   time and technical restraints (I don't have SQL installed).
   However, here's some T-SQL that should work to create a table if that
   were required:

```SQL
CREATE TABLE dbo.UserAccounts
(   EmailAddress VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL
)
GO
ALTER TABLE dbo.UserAccounts 
ADD CONSTRAINT PK_UserAccounts 
PRIMARY KEY CLUSTERED ( EmailAddress )
```

5.  **Security** : Without a better understand of the requirements it's
    hard to know what's best in this situation but storing passwords in
    plain-text like this is rarely (never?) a good idea. It normally
    considered best practice to hash passwords so that they cannot be
    retrieved.

