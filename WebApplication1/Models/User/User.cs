using System.Text.Json.Serialization;

namespace WebApplication1.Models.User;

public class User
{
    public int Id { get; set; }
    public string Password { get; set; }
    public string Email { get; set; } 

    [JsonIgnore]
    public string PasswordHash { get; set; }
}