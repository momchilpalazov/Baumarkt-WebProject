using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst.Product;
using static BaumarktSystem.Common.EntityValidationConstanst.TempSqFt;


namespace BaumarktSystem.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public Product()
        {
            this.TempQuantity = 1;  
        }

        /// [Required]

        [MaxLength(FullNameMaxLength)]
        [MinLength(FullNameMinLength)]
        public string? FullName { get; set; }



        [MaxLength(ShortProductDescriptionMaxLength)]
        [MinLength(ShortProductDescriptionMinLength)]
        public string? ShortProductDescription { get; set; }


        [MaxLength(DescriptionMaxLength)]
        [MinLength(DescriptionMinLength)]
        public string? Description { get; set; }

        
        [Range(PriceMinValue, PriceMaxValue, ErrorMessage = "Price for product muss min 1.00")]
        public decimal Price { get; set; }

        
        public string? ImageUrl { get; set; }



        [Display(Name = "Category Type")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }=null!;      

        

    
        public DateTime CreatedOn { get; set; }


        [Display(Name = "Application Type")]
        public int ApplicationTypeId { get; set; }

        [ForeignKey(nameof(ApplicationTypeId))]
        public virtual ApplicationType ApplicationType { get; set; } = null!;

        [NotMapped]
        [Display(Name = "TempSqFt")]
        [Range(TempSqFtMinValue, TempSqFtMaxValue, ErrorMessage = "TempSqFt for product muss min 1.00")]
        public int TempQuantity { get; set; }  








    }
}
