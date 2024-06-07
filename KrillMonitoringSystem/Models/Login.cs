using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KrillMonitoringSystem.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Nome")]
        [Display(Name = "NOME")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        [Column("Email")]
        [Display(Name = "EMAIL")]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        [Phone]
        [Column("Telefone")]
        [Display(Name = "TELEFONE")]
        public string Telefone { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Username")]
        [Display(Name = "USERNAME")]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Senha")]
        [Display(Name = "SENHA")]
        public string Senha { get; set; }
    }
}
