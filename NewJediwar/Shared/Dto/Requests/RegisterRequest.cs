using System.ComponentModel.DataAnnotations;

namespace NewJediwar.Shared.Dto.Requests;

public class RegisterRequest
{
    [Required]
    public string Login { get; set; }

    [Required]
    public string Password { get; set; }
}
