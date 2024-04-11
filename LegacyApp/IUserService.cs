using System;

namespace LegacyApp;

public interface IUserService
{
    public bool IsValidFistName(string firstName);
    public bool IsValidLastName(string lastName);

    public bool IsValidEmail(string email);

    public bool IsValidAge(DateTime dateOfBirth);
}