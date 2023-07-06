using System.ComponentModel.DataAnnotations;
using static BaumarktSystem.Common.EntityValidationConstanst.ApplicationType;

namespace BaumarktSystem.Data.Models
{
    public class ApplicationType
    {

        [Key]
        public int Id { get; set; } 

        [Required]
        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string Name { get; set; }=null!;

    }
}