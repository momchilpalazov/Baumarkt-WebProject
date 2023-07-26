using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BaumarktSystem.Common.EntityValidationConstanst.ApplicationType;

namespace BaumarktSystem.Data.Models
{
    public class ApplicationType
    {
       

        

        [Key]
        public Guid Id { get; set; } 

        [Required]
       
        public string? Name { get; set; }

        [Required]
        //USer
        public Guid CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public ApplicationUser Creator { get; set; } = null!;


        [Required]

        public DateTime CreatedOn { get; set; }


        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

        

       

    }
}