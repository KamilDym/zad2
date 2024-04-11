using System;

namespace LegacyApp;

public class UserValidator : IUserService
{
    public bool IsValidFistName(string firstName)
    {
        if (string.IsNullOrEmpty(firstName))
        {
            return false;
        }

        return true;
    }

    public bool IsValidLastName(string lastName)
    {
        if (string.IsNullOrEmpty(lastName))
        {
            return false;
        }

        return true;
    }

    public bool IsValidEmail(string email)
    {
        if (!email.Contains("@") && !email.Contains("."))
        {
            return false;
        }

        return true;
    }

    public bool IsValidAge(DateTime dateOfBirth)
    {
        var now = DateTime.Now;
        int age = now.Year - dateOfBirth.Year;
        if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

        if (age < 21)
        {
            return false;
        }

        return true;
    }
}