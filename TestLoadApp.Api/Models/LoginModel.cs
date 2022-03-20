#nullable disable
namespace TestLoadApp.Api.Models
{
    public class LoginModelRequest
    {
        public string Email { get; set; }   
        public string Password { get; set; }
    }

    public class LoginModelResponse
    {
        public string AccessToken { get; set; }
    }
}
