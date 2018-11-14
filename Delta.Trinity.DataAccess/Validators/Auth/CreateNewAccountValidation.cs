using Delta.Trinity.DataAccess.Commands.Auth;

namespace Delta.Trinity.DataAccess.Validators.Auth
{
    public class CreateNewAccountValidation : AccountValidation<CreateNewAccountCommand>
    {
        public CreateNewAccountValidation()
        {
            ValidateEmail();
            ValidateUserName();
        }
    }
}