namespace WebApiRestSecure.Models
{
    /// <summary>
    /// Class where we will receive the user's credentials
    /// </summary>
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}