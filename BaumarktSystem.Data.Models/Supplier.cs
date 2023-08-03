using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst.Admin;

namespace BaumarktSystem.Data.Models
{
    [Table("Supplier")]
    public class Supplier 
    {
        public Supplier()
        {
            Id = Guid.NewGuid();

        }


        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(PhoneNumberMinLength)]
        [MaxLength(PhoneNumberMaxLength)]
        public  string  PhoneNumber { get; set; } = null!;


        public Guid CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public virtual ApplicationUser Creator { get; set; } = null!;





    }
}
