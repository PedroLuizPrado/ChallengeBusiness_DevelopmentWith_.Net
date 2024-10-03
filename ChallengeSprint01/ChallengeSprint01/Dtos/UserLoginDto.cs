using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChallengeSprint01.Dtos
{
    public class UserLoginDto
    {
        [Required]
        [EmailAddress]
        public string email { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string password { get; set; } = string.Empty;
    }
}
