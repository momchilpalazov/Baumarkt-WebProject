using System.ComponentModel.DataAnnotations;
using static BaumarktSystem.Common.EntityValidationConstanst.Category;

namespace BaumarktSystem.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]        
        public string Name { get; set; }=null!;

        [Required]
        [Range(OrderMinValue, OrderMaxValue, ErrorMessage = "Order for category muss min 1")]
        public int ShowOrder { get; set; }

        [Required]
        public Guid CreatorId { get; set; } 
    
        public ApplicationUser Creator{ get; set; } = null!;

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();




    }
}