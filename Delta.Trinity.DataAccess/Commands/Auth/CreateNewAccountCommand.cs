using Delta.Trinity.DataAccess.Validators.Auth;

namespace Delta.Trinity.DataAccess.Commands.Auth
{
    public class CreateNewAccountCommand : AccountCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new CreateNewAccountValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}