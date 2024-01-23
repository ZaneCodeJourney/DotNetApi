namespace DotnetAPI.Dtos
{
    public partial class UserForLoginConfirmationDto
    {
        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt {get; set;}
        UserForLoginConfirmationDto()
        {
            if (PasswordHash == null)
            {
                PasswordHash = [];
            }
            if (PasswordSalt == null)
            {
                PasswordSalt = [];
            }
        }
    }
}