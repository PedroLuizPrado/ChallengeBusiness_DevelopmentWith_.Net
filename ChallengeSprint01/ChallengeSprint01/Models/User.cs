using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace ChallengeSprint01.Models
{

    [Table("table_odontoprev")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Column("name_odon")]
        public string Name { get; set; } = "Sem Nome";
        
        [Column("email_odon")]
        [Required]
        [EmailAddress]
        public string email { get; set; } = string.Empty;
        
        [Column("password_odon")]
        [Required]
        [StringLength(50)]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string password { get; set; } = string.Empty;
        
        [Column("cpf_odon")]
        [Required]
        [MaxLength(11)]
        public string cpf { get; set; } = string.Empty;

        [Column("tratamento_odon")]
        public int PrimeiroTratamento { get; set; }

        [Column("status_active_odon")]
        public bool isActive { get; set; } = true;
        [Column("role_pb")]
        public string Role { get; set; } = "User";
        [Column("avatar_odon")]
        public string Avatar { get; set; } = "https://sintaemasp.org.br/wp-content/uploads/2021/07/sintaema-odontoprev-beneficio-saude.jpg";

        


    }
}
