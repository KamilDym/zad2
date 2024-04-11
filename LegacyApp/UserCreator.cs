using System;

namespace LegacyApp;

public class UserCreator : IUserCreator
{
    public User CreateUser(string firstName, string lastName, string email, DateTime dateOfBirth, Client client)
    {
        var user = new User
        {
            Client = client,
            DateOfBirth = dateOfBirth,
            EmailAddress = email,
            FirstName = firstName,
            LastName = lastName
        };
        
        return user;
    }
}