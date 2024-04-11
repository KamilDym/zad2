using System;

namespace LegacyApp;

public interface IUserCreator
{
    public User CreateUser(string firstName, string lastName, string email, DateTime dateOfBirth, Client client);
}