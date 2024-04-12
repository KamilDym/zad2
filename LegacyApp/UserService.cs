using System;

namespace LegacyApp
{
    public class UserService
    {
        private readonly IUserService _userValidator;
        private readonly IUserCreator _userCreator;

        public UserService()
        {
            _userValidator = new UserValidator();
            _userCreator = new UserCreator();
        }


        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {
            if (!_userValidator.IsValidFistName(firstName))
            {
                return false;
            }

            if (!_userValidator.IsValidLastName(lastName))
            {
                return false;
            }

            if (!_userValidator.IsValidEmail(email))
            {
                return false;
            }

            if (!_userValidator.IsValidAge(dateOfBirth))
            {
                return false;
            }

            var clientRepository = new ClientRepository();
            var client = clientRepository.GetById(clientId);

            var user = _userCreator.CreateUser(firstName, lastName, email, dateOfBirth, client);

            if (user.HasCreditLimit && user.CreditLimit < 500)
            {
                return false;
            }

            UserDataAccess.AddUser(user);
            return true;
        }
    }
}