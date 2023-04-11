using System.ComponentModel.DataAnnotations;

namespace Skill_International.Models
{
    public class LoginModel
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
