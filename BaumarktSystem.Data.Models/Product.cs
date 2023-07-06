using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst.Product;

namespace BaumarktSystem.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string Name { get; set; }=null!;


        [Required]
        [MaxLength(ShortProductDescriptionMaxLength)]
        [MinLength(ShortProductDescriptionMinLength)]
        public string ShortProductDescription { get; set; }=null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [MinLength(DescriptionMinLength)]
        public string Description { get; set; }=null!;

        [Required]
        [Range(PriceMinValue, PriceMaxValue, ErrorMessage = "Price for product muss min 1.00")]
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }=null!;


        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }=null!;

        [Display(Name = "Type")]
        public int ApplicationTypeId { get; set; }

        [ForeignKey(nameof(ApplicationTypeId))]
        public virtual ApplicationType ApplicationType { get; set; }=null!;


        public Guid? ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        public virtual ApplicationUser? ApplicationUser { get; set; }=null!;


        public virtual ICollection<CartItem> CartItems { get; set; }=new HashSet<CartItem>();



    }
}
