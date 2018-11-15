using Delta.Querying.Commands.Auth;

namespace Delta.Querying.Validators.Auth
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