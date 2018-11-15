using Delta.Querying.Validators.Auth;

namespace Delta.Querying.Commands.Auth
{
    public class CreateNewAccountCommand : AccountCommand
    {
        public CreateNewAccountCommand(string username, string shaPassHash, string email)
        {
            Username = username;
            ShaPassHash = shaPassHash;
            Email = email;
        }
        
        public override bool IsValid()
        {
            ValidationResult = new CreateNewAccountValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}