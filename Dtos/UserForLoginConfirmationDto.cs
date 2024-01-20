namespace DotnetAPI.Dtos
{
    public partial class UserForLoginConfirmationDto
    {
        public byte[] PasswordHash {get; set;} = [];
        public byte[] PasswordSalt {get; set;} = [];
    }
}