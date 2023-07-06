using System.ComponentModel.DataAnnotations;
using static BaumarktSystem.Common.EntityValidationConstanst.ApplicationType;

namespace BaumarktSystem.Data.Models
{
    public class ApplicationType
    {


        public int Id { get; set; } = 0;

        [Required]
        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string Name { get; set; }=null!;

    }
}