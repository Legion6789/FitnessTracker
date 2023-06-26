namespace BusinessEntities.Models
{
    public class AuthResponseModel
    {
        public string Token { get; set; }
        public string UserId { get; set; }
        public string RefreshToken { get; set; }
    }
}
