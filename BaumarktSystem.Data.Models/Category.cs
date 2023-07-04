using System.ComponentModel.DataAnnotations;
using static BaumarktSystem.Common.EntityValidationConstanst.Category;

namespace BaumarktSystem.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string Name { get; set; }=null!;

        [Required]
        [Range(OrderMinValue, OrderMaxValue, ErrorMessage = "Order for category muss min 1")]
        public int ShowOrder { get; set; }




    }
}