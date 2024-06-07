using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KrillMonitoringSystem.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        [Phone]
        public string Telefone { get; set; }

        [Required]
        [StringLength(255)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(255)]
        public string CpfCnpj { get; set; }

        [Required]
        [ForeignKey("Login")]
        public int LoginId { get; set; }

        public virtual Login Login { get; set; }
    }
}
